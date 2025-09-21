using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.ViewModels;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,SuperAdmin")]
    [Area("Admin")]
    public class PointSystemController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public PointSystemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index(PageFilterVM filter)
        {
            var points = await _unitOfWork.PointSystemRepository.GetAllAsync(
                skip: filter.SkipNumber,
                take: filter.PageSize,
                orderBy: q => q.OrderByDescending(c => c.CreatedAt)
            );
            var data = new ModelsWithPaginationVM<PointSystem>
            {
                Items = points,
                Pagination = new PaginationVM
                {
                    PageNumber = filter.PageNumber ?? 1,
                    PageSize = filter.PageSize ?? 5,
                    TotalCount = await _unitOfWork.ContactRepository.CountAsync()
                }

            };
            return View(data);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var point = await _unitOfWork.PointSystemRepository.GetOneAsync(x => x.Id == id);
            if (point == null) 
            {
                return NotFound();
            }
            var data = new EditPointSystemVM
            {
                ActionType = point.ActionType,
                FixedPoints = point.FixedPoints,
                UnitValue   = point.UnitValue,
                PointsPerUnit = point.PointsPerUnit,
            };
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditPointSystemVM request)
        {
            if(!ModelState.IsValid)
            {
                return View(request);
            }
            var point = await _unitOfWork.PointSystemRepository.GetOneAsync(x => x.Id == id, asNoTracking:true);
            if (point == null)
            {
                return NotFound();
            }

            point.FixedPoints = request.FixedPoints;
            point.UnitValue = request.UnitValue;
            point.PointsPerUnit = request.PointsPerUnit;
             _unitOfWork.PointSystemRepository.Update(point);
            await _unitOfWork.PointSystemRepository.SaveChangesAsync();
            TempData["SuccessMessage"] = "Point System Updated successfully.";
            return RedirectToAction("Index");

        }

        


    }
}
