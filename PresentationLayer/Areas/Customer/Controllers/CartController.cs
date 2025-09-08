using CoreLayer.Enums;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.ViewModels;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;

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
            var userId = User.Identity!.IsAuthenticated ? User.FindFirstValue(ClaimTypes.NameIdentifier) : null;
            var carts = await _unitOfWork.CartRepository.GetAllAsync(
                                        filter: x => (userId != null ? x.UserId == userId : x.SessionId == sessionId),
                                        includeChain: q => q.Include(c => c.CartItems)
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
        [Route("Customer/[controller]/[action]")]
        public async Task<IActionResult> Add([FromBody] AddCartVM request)
        {
            var existingMatch = await _unitOfWork.MatchRepository.GetOneAsync(x => x.Id == request.MatchId);
            if (existingMatch == null)
            {
                return Json(new { success = false, message = "Invalid match." });
            }

            var sessionId = GetSessionId();
            var userId = User.Identity!.IsAuthenticated ? User.FindFirstValue(ClaimTypes.NameIdentifier) : null;
            var existingCart = await _unitOfWork.CartRepository.GetOneAsync(
                                            x => (userId != null ? x.UserId == userId : x.SessionId == sessionId)
                                            && x.MatchId == request.MatchId,
                                           includeChain: q => q.Include(c => c.CartItems)
                                       );
            if (existingCart != null)
            {
                if (request.CartItems.Sum(i => i.Quantity) >= MAX_TICKETS_PER_MATCH)
                {
                    return Json(new { success = false, message = $"You can only add up to {MAX_TICKETS_PER_MATCH} tickets per match." });
                }
                if (existingCart.TeamId != request.TeamId)
                {
                    return Json(new { success = false, message = "You cannot add tickets for different teams in the same match." });
                }

                if (existingCart.CartItems.Sum(i => i.Quantity) + request.CartItems.Sum(i => i.Quantity) >= MAX_TICKETS_PER_MATCH)
                {
                    return Json(new { success = false, message = $"You can only add up to {MAX_TICKETS_PER_MATCH} tickets per match." });
                }
                if (userId != null && existingCart.UserId == null)
                {
                    existingCart.UserId = userId;
                    existingCart.SessionId = null;
                    _unitOfWork.CartRepository.Update(existingCart);
                }
                else
                {
                    existingCart.SessionId = sessionId;
                }
                foreach (var item in request.CartItems)
                {
                    var existingItem = existingCart.CartItems.FirstOrDefault(i => i.TicketCategory.ToString() == item.TicketCategory);
                    if (existingItem != null)
                    {
                        existingItem.Quantity += item.Quantity;
                        _unitOfWork.CartItemRepository.Update(existingItem);
                    }
                    else
                    {
                        if (Enum.TryParse<TicketCategory>(item.TicketCategory, true, out var category))
                        {
                            var newItem = new CartItem
                            {
                                TicketCategory = category,
                                Quantity = item.Quantity,
                                CartId = existingCart.Id
                            };
                            await _unitOfWork.CartItemRepository.AddAsync(newItem);
                        }
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
                    if (Enum.TryParse<TicketCategory>(item.TicketCategory, true, out var category))
                    {
                        var newItem = new CartItem
                        {
                            TicketCategory = category,
                            Quantity = item.Quantity,
                            CartId = newCart.Id
                        };
                        await _unitOfWork.CartItemRepository.AddAsync(newItem);
                        await _unitOfWork.CartItemRepository.SaveChangesAsync();
                    }
                    
                }
                return Json(new { success = true, message = "Cart created and items added successfully." });
            }

        }

        [HttpPost]
        public async Task<IActionResult> Remove([FromBody] RemoveCartItemVM request)
        {
            var sessionId = GetSessionId();
            var userId = User.Identity!.IsAuthenticated ? User.FindFirstValue(ClaimTypes.NameIdentifier) : null;
            Expression<Func<CartItem, bool>> filter =  i => i.CartId == request.CartId && i.TicketCategory.ToString() == request.TicketCategory
                                    && (userId != null ? i.Cart.UserId == userId : i.Cart.SessionId == sessionId);

            var ExistingItem = await  _unitOfWork.CartItemRepository.GetOneAsync(filter);
            if(ExistingItem == null)
            {
                return Json(new { success = false, message = "Item not found." });
            }
            await _unitOfWork.CartItemRepository.DeleteAsync(filter);
            await _unitOfWork.CartItemRepository.SaveChangesAsync();
            return Json(new { success = true, message = "Cart Item Deleted successfully." });
        }

        [HttpPost]
        public async Task<IActionResult> UpdateItemQuantity([FromBody] UpdateItemQuantityVM request)
        {
            var sessionId = GetSessionId();
            var userId = User.Identity!.IsAuthenticated ? User.FindFirstValue(ClaimTypes.NameIdentifier) : null;
            Expression<Func<CartItem, bool>> filter = i => i.CartId == request.CartId && i.TicketCategory.ToString() == request.TicketCategory
                                    && (userId != null ? i.Cart.UserId == userId : i.Cart.SessionId == sessionId);

            var ExistingItem = await _unitOfWork.CartItemRepository.GetOneAsync(filter, includeChain: q => q.Include(c => c.Cart).ThenInclude(x => x.CartItems));
            if (ExistingItem == null)
            {
                return Json(new { success = false, message = "Item not found." });
            }

            if (request.Increase)
            {
                if (ExistingItem.Cart.CartItems.Sum(i => i.Quantity) >= MAX_TICKETS_PER_MATCH)
                {
                    return Json(new { success = false, message = $"You can only have up to {MAX_TICKETS_PER_MATCH} tickets per match." });
                }
                ExistingItem.Quantity += 1;
            }
            else
            {
                if (ExistingItem.Quantity <= 1)
                {
                    await _unitOfWork.CartItemRepository.DeleteAsync(filter);
                    await _unitOfWork.CartItemRepository.SaveChangesAsync();
                    return Json(new { success = false, message = "Quantity cannot be less than 1." });
                }
               
                ExistingItem.Quantity -= 1;
            }

            _unitOfWork.CartItemRepository.Update(ExistingItem);
            await _unitOfWork.CartItemRepository.SaveChangesAsync();

            return Json(new { success = true, message = "Cart Item Quantity Updated successfully." } );

        }

        private string GetSessionId()
        {
            const string cookieName = "GuestSessionId";
            if (!Request.Cookies.TryGetValue(cookieName, out var sessionId))
            {
                sessionId = Guid.NewGuid().ToString();
                Response.Cookies.Append(cookieName, sessionId, new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddDays(30), 
                    HttpOnly = true,
                    IsEssential = true
                });
            }
            return sessionId;
        }

    }
}
