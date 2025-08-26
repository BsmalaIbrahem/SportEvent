using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class PlayerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
