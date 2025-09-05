using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Customer.Controllers
{
    public class CartController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CartController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Remove()
        {
            return View();
        }

        public IActionResult Edit()
        {
              return View();
        }
    }
}
