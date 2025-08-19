using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.ViewModels;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin,SuperAdmin")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Dashboard(DashboardFilterVM filter)
        {
            var Tournment = await _unitOfWork.TournamentRepository.GetOneAsync(t => t.Title == filter.Title && t.Season == filter.Season);
            if (Tournment == null)
            {
                ModelState.AddModelError("", "No tournament found with the specified title and season.");
                return View(new DashboardFilterVM());
            }

            //
            return View();
        }
    }
}
