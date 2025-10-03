using CoreLayer.Enums;
using DataAccessLayer.Data;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using Hangfire.Server;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.Services;
using PresentationLayer.Services.IServices;
using PresentationLayer.ViewModels;
using Stripe.Checkout;
using Stripe.Climate;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PresentationLayer.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class TicketController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly TicketService _service;
        private readonly IPdfService _pdfService;
        public TicketController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> _userManager, TicketService service, IPdfService pdfService)
        {
            _unitOfWork = unitOfWork;
            this._userManager = _userManager;
            _service = service;
            _pdfService = pdfService;
        }

        [Authorize]
        public async Task<IActionResult> Index(PageFilterVM filter)
        {
            var user = await GetUser();
            if (user == null)
            {
                return NotFound();
            }
            Expression<Func<Ticket, bool>>? filterExpression = c => c.Status == TicketStatus.Confirmed && c.UserId == user.Id;
            var tickets = await _unitOfWork.TicketRepository.GetAllAsync(
                     filter: filterExpression,
                     skip:filter.SkipNumber, 
                     take: filter.PageSize,
                     orderBy: x => x.OrderByDescending(q => q.CreatedAt),
                     includeChain: Queryable => Queryable.Include(t => t.TicketMatches)
                );

            var data = new ModelsWithPaginationVM<Ticket>
            {
                Items = tickets,
                Pagination = new PaginationVM
                {
                    PageNumber = filter.PageNumber ?? 1,
                    PageSize = filter.PageSize ?? 5,
                    TotalCount = await _unitOfWork.TicketRepository.CountAsync(filterExpression)
                }
            };
            return View(data);
        }

        [Authorize]
        public async Task<IActionResult> Details(string referenceId)
        {
            var user = await GetUser();
            if (user == null)
            {
                return NotFound();
            }

            var tickect = await _unitOfWork.TicketRepository.GetOneAsync(
                                                x => x.ReferenceId == referenceId && x.Status == TicketStatus.Confirmed && x.UserId == user.Id,
                                                includeChain : q => q.Include(t => t.TicketMatches)
                                                                    .ThenInclude(m => m.Match)
                                                                    .ThenInclude(ht => ht.HomeTeam)
                                                                    .Include(t => t.TicketMatches)
                                                                    .ThenInclude(m => m.Match)
                                                                    .ThenInclude(at => at.AwayTeam)
                                                                    .Include(t => t.TicketMatches)
                                                                    .ThenInclude(tm => tm.Team)
                                 );

            if (tickect == null)
            {
                return NotFound();
            }

            return View(tickect);
        }

        [HttpPost]
        public async Task<IActionResult> Pay()
        {
            var user = await GetUser();
            if (user == null)
            {
                return NotFound();
            }
            var carts = await _unitOfWork.CartRepository.GetAllAsync(c => c.UserId == user.Id, includeChain: 
                                                                            q => q.Include(x => x.CartItems)
                                                                                    .Include(x => x.Match)
                                                                                    .ThenInclude(x => x.HomeTeam)
                                                                                    .Include(x => x.Match)
                                                                                    .ThenInclude(x => x.AwayTeam)
                                                                                    .Include(x => x.Match)
                                                                                    .ThenInclude(x => x.TicketPrices)
                                                                    ); 
            if(carts == null || !carts.Any() || carts.All(c => c.CartItems == null || !c.CartItems.Any()))
            {
                return RedirectToAction("Index", "Cart", new { area = "Customer" });
            }

            using var transaction = await _unitOfWork.BeginTransactionAsync();
            var ticket = new Ticket();

            try
            {
                ticket = new Ticket
                {
                    Status = TicketStatus.Pending,
                    UserId = user.Id,
                    ReferenceId = Guid.NewGuid().ToString(),
                    Quantity = carts.Sum(c => c.CartItems.Sum(ci => ci.Quantity))
                };

                await _unitOfWork.TicketRepository.AddAsync(ticket);
                await _unitOfWork.TicketRepository.SaveChangesAsync();

                var options = new SessionCreateOptions
                {
                    PaymentMethodTypes = new List<string> { "card" },
                    LineItems = new List<SessionLineItemOptions>(),
                    Mode = "payment",
                    SuccessUrl = $"{Request.Scheme}://{Request.Host}/Customer/Checkout/Success?referenceId={ticket.ReferenceId}",
                    CancelUrl = $"{Request.Scheme}://{Request.Host}/Customer/Checkout/Cancel?referenceId={ticket.ReferenceId}",
                };

                foreach (var cart in carts)
                {
                    if (cart.CartItems == null || !cart.CartItems.Any())
                    {
                        throw new Exception("Cart is empty.");
                    }

                    if (cart?.CartItems?.Sum(i => i.Quantity) > 4)
                    {
                        throw new Exception("You can not buy more than 4 tickets for the same match.");
                    }

                    var lastTotalTickets = await _service.GetTotalTicketsForMatch(cart!.MatchId, user.Id);

                    if (lastTotalTickets + cart?.CartItems?.Sum(i => i.Quantity) > 4)
                    {
                        throw new Exception("You can not buy more than 4 tickets for the same match.");
                    }

                    var isSameMatchTeam = await _service.IsSameMatchTeam(cart.MatchId, user.Id, cart.TeamId);
                    if (!isSameMatchTeam && lastTotalTickets > 0)
                    {
                        throw new Exception("You can not buy tickets for different teams in the same match.");
                    }

                    foreach (var cartItem in cart?.CartItems)
                    {
                        if (cartItem.Quantity <= 0)
                        {
                            new Exception("Quantity must be greater than zero.");
                        }
                        var matchTicketPrice = cart?.Match?.TicketPrices
                                                        .Where(x => x.Category == cartItem.TicketCategory)
                                                        .FirstOrDefault();
                        var availableTickets = 0;
                        if (cart.Match.HomeTeamId == cart.TeamId)
                        {
                            availableTickets = matchTicketPrice!.HomeTickets;

                        }
                        else if (cart.Match.AwayTeamId == cart.TeamId)
                        {
                            availableTickets = matchTicketPrice!.AwayTickets;
                        }
                        else
                        {
                            throw new Exception("Invalid team selection for the match.");
                        }
                        if (availableTickets < cartItem.Quantity)
                        {
                           throw new Exception($"Not enough available tickets for  {cartItem.TicketCategory} in match : {cart.Match.HomeTeam.Name} VS {cart.Match.AwayTeam.Name}");
                        }

                        var ticketMatch = new TicketMatch
                        {
                            TicketId = ticket.Id,
                            MatchId = cart.MatchId,
                            TeamId = cart.TeamId,
                            Price = cart?.Match?.TicketPrices
                                         .Where(x => x.Category == cartItem.TicketCategory)
                                         .FirstOrDefault()?.Price ?? 0,
                            Category = cartItem.TicketCategory,
                            Quantity = cartItem.Quantity
                        };

                        await _unitOfWork.TicketMatchRepository.AddAsync(ticketMatch);
                        
                        if (cart.Match.HomeTeamId == cart.TeamId)
                        {
                            matchTicketPrice!.HomeTickets -= cartItem.Quantity;
                        }
                        else if (cart.Match.AwayTeamId == cart.TeamId)
                        {
                            matchTicketPrice!.AwayTickets -= cartItem.Quantity;
                        }


                        options.LineItems.Add(new SessionLineItemOptions
                        {
                            PriceData = new SessionLineItemPriceDataOptions
                            {
                                Currency = "egp",
                                ProductData = new SessionLineItemPriceDataProductDataOptions
                                {
                                    Name = cart.Match.HomeTeam.Name + " VS " + cart.Match.AwayTeam.Name,
                                    Description = $"Category: {cartItem.TicketCategory} For : {cart.Team.Name} ",
                                },
                                UnitAmount = (long)ticketMatch.Price * 100,
                            },
                            Quantity = ticketMatch.Quantity,
                        });


                        _unitOfWork.TicketPriceRepository.Update(matchTicketPrice!);
                        await _unitOfWork.TicketPriceRepository.SaveChangesAsync();
                    }
                }

                await _unitOfWork.TicketMatchRepository.SaveChangesAsync();

                var service = new SessionService();
                var session = service.Create(options);
                ticket.SessionId = session.Id;
                ticket.PaymentMethod = "Card";
                ticket.ExpiryDate = DateTime.Now.AddMinutes(1);
                _unitOfWork.TicketRepository.Update(ticket);
                await _unitOfWork.TicketRepository.SaveChangesAsync();

                Response.Cookies.Append("TicketId", ticket.ReferenceId.ToString(), new CookieOptions
                {
                    Expires = DateTimeOffset.Now.AddMinutes(1)
                });

                await transaction.CommitAsync();
                return Redirect(session.Url ?? string.Empty);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Index", "Cart", new {Area = "Customer" });
            }
            

        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Download(int ticketMatchId)
        {
            var user = await GetUser();
            if (user == null)
            {
                return NotFound();
            }
            var ticketMatch = await _unitOfWork.TicketMatchRepository.GetOneAsync(
                                                x => x.Id == ticketMatchId && x.Ticket.UserId == user.Id,
                                                includeChain: q => q.Include(t => t.Ticket)
                                                                    .Include(t => t.Match)
                                                                    .ThenInclude(ht => ht.HomeTeam)
                                                                    .Include(t => t.Match)
                                                                    .ThenInclude(at => at.AwayTeam)
                                                                    .Include(t => t.Team)
                                 );
            
            if (ticketMatch == null)
            {
                return NotFound();
            }
            var pdfBytes =  _pdfService.GeneratePdf(ticketMatch);

            if (pdfBytes == null || pdfBytes.Length == 0)
                return NotFound();

            return File(pdfBytes, "application/pdf", $"Ticket_{ticketMatchId}.pdf");

        }
        private async Task<ApplicationUser?> GetUser()
        {
            return await _userManager.GetUserAsync(User);
        }
    }
}
