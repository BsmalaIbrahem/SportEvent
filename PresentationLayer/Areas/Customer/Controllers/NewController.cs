using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
