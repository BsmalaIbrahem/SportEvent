using Azure.Core;
using CoreLayer.Helpers;
using DataAccessLayer.Data;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.ViewModels;
using System.Linq.Expressions;
using System.Numerics;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class NewsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;

        public NewsController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
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

        public IActionResult Create()
        {
            return View(new CreateNewsVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateNewsVM newsVM, IFormFile? ImgPath)
        {
            ModelState.Remove("Author");
            if (!ModelState.IsValid)
            {
                return View(newsVM);
            }

            if (ImgPath != null && ImgPath.Length > 0)
            {
                string fileName = FileHelper.CreateFileName(ImgPath.FileName);
                var path = "assets\\images\\News";
                string filePath = FileHelper.GetFilePath(fileName, "wwwroot\\" + path);
                await FileHelper.UploadFile(filePath, ImgPath);
                newsVM.ImgPath = "/" + path.Replace("\\", "/") + "/" + fileName;
            }
            else
            {
                ModelState.AddModelError("ImgPath", "Image is required.");
                return View(newsVM);
            }

            if (string.IsNullOrEmpty(newsVM.AuthorId))
            {
                var user = await _userManager.FindByNameAsync(User.Identity?.Name!);
                if (user != null)
                {
                    newsVM.AuthorId = user.Id;
                }
                else
                {
                    return NotFound();
                }
            }

            var news = new New
            {
                Id = newsVM.Id,
                Title = newsVM.Title,
                Content = newsVM.Content,
                ImgPath = ImgPath != null ? newsVM.ImgPath : null,
                AuthorId = newsVM.AuthorId

            };

            await _unitOfWork.NewRepository.AddAsync(news);
            await _unitOfWork.NewRepository.SaveChangesAsync();
            TempData["SuccessMessage"] ="New Has Been Created Successfuly";
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var news = await _unitOfWork.NewRepository.GetOneAsync(e => e.Id == id, includeChain: c => c.Include(t => t.Author));
            if (news is null)
            {
                return NotFound();
            }
            var newsVM = new CreateNewsVM
            {
                Id = news.Id,
                Title = news.Title,
                Content = news.Content,
                ImgPath = news.ImgPath,
                AuthorId = news.AuthorId
            };
            return View(newsVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CreateNewsVM newsVM, IFormFile? ImgPath)
        {
            ModelState.Remove("Author");
            if (!ModelState.IsValid)
            {
                return View(newsVM);
            }
            var news = await _unitOfWork.NewRepository.GetOneAsync(e => e.Id == newsVM.Id);
            if (news is null)
            {
                return NotFound();
            }
            if (ImgPath != null && ImgPath.Length > 0)
            {
                if (!string.IsNullOrEmpty(news.ImgPath))
                {
                    var oldImagePath = Path.Combine("wwwroot", news.ImgPath.TrimStart('/').Replace("/", "\\"));
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }
                string fileName = FileHelper.CreateFileName(ImgPath.FileName);
                var path = "assets\\images\\News";
                string filePath = FileHelper.GetFilePath(fileName, "wwwroot\\" + path);
                await FileHelper.UploadFile(filePath, ImgPath);
                newsVM.ImgPath = "/" + path.Replace("\\", "/") + "/" + fileName;
            }
            else
            {
                newsVM.ImgPath = news.ImgPath;
            }


            if (string.IsNullOrEmpty(newsVM.AuthorId))
            {
                var user = await _userManager.FindByNameAsync(User.Identity?.Name!);
                if (user != null)
                {
                    newsVM.AuthorId = user.Id;
                }
                else
                {
                    return NotFound();
                }
            }
            news.Title = newsVM.Title;
            news.Content = newsVM.Content;
            news.ImgPath = newsVM.ImgPath;
            news.AuthorId = newsVM.AuthorId;
            _unitOfWork.NewRepository.Update(news);
            await _unitOfWork.NewRepository.SaveChangesAsync();
            TempData["SuccessMessage"] ="New Has Been Updated Successfuly";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var news = await _unitOfWork.NewRepository.GetOneAsync(e => e.Id == id);
            if (news is null)
            {
                return NotFound();
            }
            if (!string.IsNullOrEmpty(news.ImgPath))
            {
                var oldImagePath = Path.Combine("wwwroot", news.ImgPath.TrimStart('/').Replace("/", "\\"));
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            await _unitOfWork.NewRepository.DeleteAsync(e => e.Id == id);
            await _unitOfWork.NewRepository.SaveChangesAsync();
            TempData["SuccessMessage"] ="New Has Been Deleted Successfuly";
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var details = await _unitOfWork.NewRepository
                .GetOneAsync(e => e.Id == id, includeChain: c => c.Include(t => t.Author));

            if (details is null)
            {
                return NotFound();
            }

            return View(details);
        }
    }
}
