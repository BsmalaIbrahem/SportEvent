using CoreLayer.Helpers;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.ViewModels;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class CoachController : Controller
    {
        private readonly IRepository<Coach> _repository;
        public CoachController(IRepository<Coach> repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> Index(PageFilterVM filter)
        {
            Expression<Func<Coach, bool>>? filterExpression = c => string.IsNullOrEmpty(filter.SearchTerm) || c.Name.Contains(filter.SearchTerm);
            var coaches = await _repository.GetAllAsync(
                filter: filterExpression,
                skip: filter.SkipNumber,
                take: filter.PageSize,
                orderBy: q => q.OrderByDescending(c => c.Id),
                includeChain: q => q.Include(c => c.Team)
            );
            var data = new ModelsWithPaginationVM<Coach>
            {
                Items = coaches,
                Pagination = new PaginationVM
                {
                    PageNumber = filter.PageNumber ?? 1 ,
                    PageSize = filter.PageSize ?? 5,
                    TotalCount = await _repository.CountAsync(filterExpression)
                }

            };
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCoachVM request, IFormFile ImgPath)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var coach = new Coach
            {
                Name = request.Name,
                Description = request.Description,
                Nationality = request.Nationality,
            };
            if(ImgPath != null && ImgPath.Length > 0)
            {
                string fileName = FileHelper.CreateFileName(ImgPath.FileName);
                var path = "assets\\images\\coaches";
                string filePath = FileHelper.GetFilePath(fileName, "wwwroot\\" + path);
                await FileHelper.UploadFile(filePath, ImgPath);
                coach.ImageUrl = "/" + path.Replace("\\", "/") + "/" + fileName;
            }
            else
            {
                ModelState.AddModelError("ImgPath", "Image is required.");
                return View(request);
            }
            await _repository.AddAsync(coach);
            await _repository.SaveChangesAsync();

            TempData["SuccessMessage"] = "Coach created successfully.";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var existingCoach = await _repository.GetOneAsync(c => c.Id == id);
            if(existingCoach == null)
            {
                return NotFound();
            }
            var coach = new EditCoachVM
            {
                Id = existingCoach.Id,
                Name = existingCoach.Name,
                Description = existingCoach.Description,
                Nationality = existingCoach.Nationality,
                ImgPath = existingCoach.ImageUrl
            };

            return View(coach);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditCoachVM coach, IFormFile ImgPath)
        {
            ModelState.Remove("ImgPath");
            if (!ModelState.IsValid)
            {
                return View(coach);
            }
            var existingCoach = await _repository.GetOneAsync(c => c.Id == coach.Id, asNoTracking: true);
            if (existingCoach == null)
            {
                return NotFound();
            }

            existingCoach.Name = coach.Name;
            existingCoach.Description = coach.Description;
            existingCoach.Nationality = coach.Nationality;

            if (ImgPath != null && ImgPath.Length > 0)
            {
                if (!string.IsNullOrEmpty(existingCoach.ImageUrl))
                {
                    var oldImagePath = Path.Combine("wwwroot", existingCoach.ImageUrl.TrimStart('/').Replace("/", "\\"));
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }
                string fileName = FileHelper.CreateFileName(ImgPath.FileName);
                var path = "assets\\images\\coaches";
                string filePath = FileHelper.GetFilePath(fileName, "wwwroot\\" + path);
                await FileHelper.UploadFile(filePath, ImgPath);
                existingCoach.ImageUrl = "/" + path.Replace("\\", "/") + "/" + fileName;
            }

            _repository.Update(existingCoach);
            await _repository.SaveChangesAsync();

            TempData["SuccessMessage"] = "Coach Edit successfully.";

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Archive(int id)
        {
            var existingCoach = await _repository.GetOneAsync(c => c.Id == id);
            if (existingCoach == null)
            {
                existingCoach = await _repository.GetOneAsync(c => c.Id == id, IsDeleted: true);
                if (existingCoach == null)
                {
                    return NotFound();
                }
                await _repository.AddToArchiveAsync(c => c.Id == id);
                await _repository.SaveChangesAsync();
                TempData["SuccessMessage"] = "Coach Removed from Archive successfully.";
                return RedirectToAction(nameof(Index));
            }

            await _repository.AddToArchiveAsync(c => c.Id == id);
            await _repository.SaveChangesAsync();
            TempData["SuccessMessage"] = "Coach Moved To Archive successfully.";
            return RedirectToAction(nameof(Index));
        }

    }
}
