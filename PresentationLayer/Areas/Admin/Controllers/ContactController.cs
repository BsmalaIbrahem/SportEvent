using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.ViewModels;
using System.Linq.Expressions;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class ContactController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index(PageFilterVM filter)
        {
            Expression<Func<Contact, bool>>? filterExpression = c => string.IsNullOrEmpty(filter.SearchTerm) || c.Name.Contains(filter.SearchTerm);
            var contact = await _unitOfWork.ContactRepository.GetAllAsync(
                filter: filterExpression,
                skip: filter.SkipNumber,
                take: filter.PageSize,
                orderBy: q => q.OrderByDescending(c => c.CreatedAt),
                asNoTracking : true
            );
            var data = new ModelsWithPaginationVM<Contact>
            {
                Items = contact,
                Pagination = new PaginationVM
                {
                    PageNumber = filter.PageNumber ?? 1,
                    PageSize = filter.PageSize ?? 5,
                    TotalCount = await _unitOfWork.ContactRepository.CountAsync(filterExpression)
                }

            };
            return View(data);
        }

        public async Task<IActionResult> Details(int id)
        {
            var contact = await _unitOfWork.ContactRepository.GetOneAsync(e => e.Id == id);

            if (contact is null)
            {
                return NotFound();
            }

            if (!contact.IsRead)
            {
                contact.IsRead = true;
                await _unitOfWork.ContactRepository.SaveChangesAsync();
            }

            return View(contact);
        }

    }
}
