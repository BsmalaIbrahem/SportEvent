using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ContactController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Contact());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Contact contact)
        {
            if(!ModelState.IsValid)
            {
                return NotFound();
            }

            contact.IsRead = false;

            await _unitOfWork.ContactRepository.AddAsync(contact);
            await _unitOfWork.ContactRepository.SaveChangesAsync();

            TempData["SuccessMessage"] = "Message Sent Succsesfully";

            return RedirectToAction("Index");
        }
    }
}
