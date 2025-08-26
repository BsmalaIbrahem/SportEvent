using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class MatchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
