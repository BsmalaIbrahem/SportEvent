using DataAccessLayer.Data;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public UserController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index(PageFilterVM filter)
        {

            var expectUsers = await _userManager.GetUsersInRoleAsync("SuperAdmin");
            var users = await  _userManager.Users.Where(x => !expectUsers.Select(e => e.Id).Contains(x.Id))
                                            .Skip(filter.SkipNumber ?? 0).Take(filter.PageSize ?? 5)
                                            .ToListAsync();
           
            var data = new ModelsWithPaginationVM<ApplicationUser>
            {
                Items = users,
                Pagination = new PaginationVM
                {
                    PageNumber = filter.PageNumber ?? 1,
                    PageSize = filter.PageSize ?? 5,
                    TotalCount = await _userManager.Users.CountAsync()
                }

            };
            return View(data);
        }
    }
}
