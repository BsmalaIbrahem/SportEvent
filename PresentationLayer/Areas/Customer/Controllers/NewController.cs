using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.ViewModels;
using System.Linq.Expressions;

namespace PresentationLayer.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class NewController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public NewController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index(PageFilterVM filter)
        {
            Expression<Func<New, bool>>? filterExpression = c => string.IsNullOrEmpty(filter.SearchTerm) || c.Title.Contains(filter.SearchTerm);
            var news = await _unitOfWork.NewRepository.GetAllAsync(
                filter: filterExpression,
                skip: filter.SkipNumber,
                take: filter.PageSize,
                orderBy: q => q.OrderByDescending(c => c.Id),
                includeChain: c => c.Include(t => t.Author)
            );
            var data = new ModelsWithPaginationVM<New>
            {
                Items = news,
                Pagination = new PaginationVM
                {
                    PageNumber = filter.PageNumber ?? 1,
                    PageSize = filter.PageSize ?? 5,
                    TotalCount = await _unitOfWork.NewRepository.CountAsync(filterExpression)
                }

            };
            return View(data);
        }
    
        
        public async Task<IActionResult> Details(int id)
        {
            var news = await _unitOfWork.NewRepository.GetOneAsync(
                 n => n.Id == id,
                includeChain: n => n.Include(a => a.Author)
            );
            if (news == null)
            {
                return NotFound();
            }
            return View(news);
        }

    }
}
