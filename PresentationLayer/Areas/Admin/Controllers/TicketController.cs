using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.ViewModels;
using System.Linq.Expressions;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TicketController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public TicketController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index(TicketFilterVM filter)
        {
            Expression<Func<Ticket, bool>>? filterExpression = null;

            if (filter?.Status != null)
            {
                filterExpression = c => c.Status == filter.Status;
            }

            var tickets = await _unitOfWork.TicketRepository.GetAllAsync(
                filter: filterExpression,
                skip: filter?.PageFilter?.SkipNumber ?? 0,
                take: filter?.PageFilter?.PageSize ?? 10,
                orderBy: q => q.OrderByDescending(c => c.Id),
                includeChain: q => q.Include(c => c.Match)
                                    .ThenInclude(t => t.HomeTeam)
                                    .Include(c => c.Match)
                                    .ThenInclude(t => t.AwayTeam)
                                    .Include(c => c.User)
            );

            var data = new ModelsWithPaginationVM<Ticket>
            {
                Items = tickets,
                Pagination = new PaginationVM
                {
                    PageNumber = filter.PageFilter.PageNumber ?? 1,
                    PageSize = filter.PageFilter.PageSize ?? 5,
                    TotalCount = await _unitOfWork.TicketRepository.CountAsync(filterExpression)
                }

            };
            ViewBag.Status = filter.Status;
            return View(data);
        }
    }
}
