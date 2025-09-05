using Azure.Core;
using CoreLayer.Enums;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.ViewModels;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CartController : Controller
    {
        private const int MAX_TICKETS_PER_MATCH = 4;
        private readonly IUnitOfWork _unitOfWork;
        public CartController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
            var sessionId = GetSessionId();
            var userId = User.Identity!.IsAuthenticated ? User.Claims.First(c => c.Type == "UserId").Value : null;
            var carts = await _unitOfWork.CartRepository.GetAllAsync(
                                        filter: x => (userId != null ? x.UserId == userId : x.SessionId == sessionId),
                                        includeChain: q => q.Include(c => c.CartItems)
                                                            .ThenInclude(i => i.Cart)
                                                            .Include(c => c.Match)
                                                            .ThenInclude(m => m.HomeTeam)
                                                            .Include(c => c.Match)
                                                            .ThenInclude(m => m.AwayTeam)
                                                            .Include(c => c.Match)
                                                            .ThenInclude(m => m.TicketPrices)
                                                            .Include(c => c.Team)
                                    );


            return View(carts);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddCartVM request)
        {
          
            var sessionId = GetSessionId(); 
            var userId = User.Identity!.IsAuthenticated ? User.Claims.First(c => c.Type == "UserId").Value : null;
            var existingCart = await _unitOfWork.CartRepository.GetOneAsync(
                                            x => (userId != null ? x.UserId == userId : x.SessionId == sessionId)
                                            && x.MatchId == request.MatchId,
                                           includeChain : q  => q.Include(c => c.CartItems)
                                       ); 
            if(existingCart != null)
            {
                if(existingCart.CartItems.Sum(i => i.Quantity) >= MAX_TICKETS_PER_MATCH)
                {
                    return Json(new { success = false, message = $"You can only add up to {MAX_TICKETS_PER_MATCH} tickets per match." });
                }
                if(existingCart.TeamId != request.TeamId)
                {
                    return Json(new { success = false, message = "You cannot add tickets for different teams in the same match." });
                }

                if(existingCart.CartItems.Count + request.CartItems.Count > MAX_TICKETS_PER_MATCH)
                {
                    return Json(new { success = false, message = $"You can only add up to {MAX_TICKETS_PER_MATCH} tickets per match." });
                }
                if(userId != null && existingCart.UserId == null)
                {
                    existingCart.UserId = userId;
                    existingCart.SessionId = null;
                    _unitOfWork.CartRepository.Update(existingCart);                }
                else
                {
                    existingCart.SessionId = sessionId;
                }
                foreach (var item in request.CartItems)
                {
                        var existingItem = existingCart.CartItems.FirstOrDefault(i => i.TicketCategory == item.TicketCategory);
                        if (existingItem != null)
                        {
                            existingItem.Quantity += item.Quantity;
                            _unitOfWork.CartItemRepository.Update(existingItem);
                        }
                        else
                        {
                            var newItem = new CartItem
                            {
                                TicketCategory = item.TicketCategory,
                                Quantity = item.Quantity,
                                CartId = existingCart.Id
                            };
                            await _unitOfWork.CartItemRepository.AddAsync(newItem);
                        }
                }
                await _unitOfWork.CartRepository.SaveChangesAsync();
                await _unitOfWork.CartItemRepository.SaveChangesAsync();
                return Json(new { success = true, message = "Cart updated successfully." });

            }
            else
            {
                if (request.CartItems.Count > MAX_TICKETS_PER_MATCH)
                {
                    return Json(new { success = false, message = $"You can only add up to {MAX_TICKETS_PER_MATCH} tickets per match." });
                }

                var newCart = new Cart
                {
                    UserId = userId,
                    SessionId = userId == null ? sessionId : null,
                    MatchId = request.MatchId,
                    TeamId = request.TeamId,
                };
                await _unitOfWork.CartRepository.AddAsync(newCart);
                await _unitOfWork.CartRepository.SaveChangesAsync();
                foreach (var item in request.CartItems)
                {
                    var newItem = new CartItem
                    {
                        TicketCategory = item.TicketCategory,
                        Quantity = item.Quantity,
                        CartId = newCart.Id
                    };
                    await _unitOfWork.CartItemRepository.AddAsync(newItem);
                    await _unitOfWork.CartItemRepository.SaveChangesAsync();
                }
                return Json(new { success = true, message = "Cart created and items added successfully." });
            }

        }

        [HttpPost]
        public async Task<IActionResult> Remove(RemoveCartItemVM request)
        {
            var sessionId = GetSessionId();
            var userId = User.Identity!.IsAuthenticated ? User.Claims.First(c => c.Type == "UserId").Value : null;
            Expression<Func<CartItem, bool>> filter =  i => i.CartId == request.CartId && i.TicketCategory == request.TicketCategory
                                    && (userId != null ? i.Cart.UserId == userId : i.Cart.SessionId == sessionId);

            var ExistingItem = await  _unitOfWork.CartItemRepository.GetOneAsync(filter);
            if(ExistingItem == null)
            {
                return Json(new { success = false, message = "Item not found." });
            }
            await _unitOfWork.CartItemRepository.DeleteAsync(filter);
            await _unitOfWork.CartItemRepository.SaveChangesAsync();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int cartId, TicketCategory ticketCategory)
        {
            var sessionId = GetSessionId();
            var userId = User.Identity!.IsAuthenticated ? User.Claims.First(c => c.Type == "UserId").Value : null;
            Expression<Func<CartItem, bool>> filter = i => i.CartId == cartId && i.TicketCategory == ticketCategory
                                    && (userId != null ? i.Cart.UserId == userId : i.Cart.SessionId == sessionId);

            var ExistingItem = await _unitOfWork.CartItemRepository.GetOneAsync(filter, 
                                                                    includeChain: x => x.Include(q => q.Cart)
                                                                                    .ThenInclude(x => x.Match)
                                                                                    .ThenInclude(m => m.TicketPrices)

                                                            );
            if (ExistingItem == null)
            {
                return NotFound();
            }
            var data = new EditCartItemVM
            {
                CartId = ExistingItem.CartId,
                TicketCategory = ExistingItem.TicketCategory,
                Quantity = ExistingItem.Quantity
            };

            return Json(new { success = true, data = data });
        }

        [HttpPost]
        public IActionResult Edit(EditCartItemVM request)
        {
            return View();
        }

        private string GetSessionId()
        {
           if(HttpContext.Session.GetString("GuestSessionId") == null)
           {
                var sessionId = Guid.NewGuid().ToString();
                HttpContext.Session.SetString("GuestSessionId", sessionId);
           }
            return HttpContext.Session.GetString("GuestSessionId")!;
        }
    }
}
