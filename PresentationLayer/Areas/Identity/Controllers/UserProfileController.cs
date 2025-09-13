using CoreLayer.Enums;
using CoreLayer.Helpers;
using DataAccessLayer.Data;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.ViewModels;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Identity.Controllers
{
    [Area("Identity")]
    [Authorize]
    public class UserProfileController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserProfileController(IUnitOfWork unitOfWork,UserManager<ApplicationUser> userManager,RoleManager<IdentityRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
           var user = await _userManager.GetUserAsync(User);

            if (user is null)
                return NotFound();

            var model = new UserProfileVM
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email!,
                PhoneNumber = user.PhoneNumber,
                Address = user.Address,
                Points = user.Points,
                ProfilePictureUrl = user.ProfilePictureUrl
            };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user is null)
                return NotFound();

            var model = new UserProfileVM
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email!,
                PhoneNumber = user.PhoneNumber,
                Address = user.Address,
                Points = user.Points,
                ProfilePictureUrl = user.ProfilePictureUrl
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserProfileVM userProfile)
        {
            if(!ModelState.IsValid)
                return NotFound(userProfile);

            var user = await _userManager.FindByIdAsync(userProfile.Id);
            if(user is null)
                return NotFound();

            var isPasswordValid = await _userManager.CheckPasswordAsync(user, userProfile.CurrentPassword);

            if (isPasswordValid)
            {
                user.FirstName = userProfile.FirstName;
                user.LastName = userProfile.LastName;
                user.Email = userProfile.Email;
                user.PhoneNumber = userProfile.PhoneNumber;
                user.Address = userProfile.Address;
            }
            else
            {
                ModelState.AddModelError("CurrentPassword", "InVaild Password");
                return View(userProfile);
            }

            // Change ProfilePic If Exist
            if (userProfile.ProfilePicture != null && userProfile.ProfilePicture.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/assets/images/profiles");
                if (!Directory.Exists(uploadsFolder))
                    Directory.CreateDirectory(uploadsFolder);
                // Delete the old one if exist
                if (!string.IsNullOrEmpty(user.ProfilePictureUrl))
                {
                    var oldImagePath = Path.Combine(uploadsFolder, user.ProfilePictureUrl);
                    if (System.IO.File.Exists(oldImagePath))
                        System.IO.File.Delete(oldImagePath);
                }
                // upload the new one
                var fileName = Guid.NewGuid() + Path.GetExtension(userProfile.ProfilePicture.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await userProfile.ProfilePicture.CopyToAsync(stream);
                }
                user.ProfilePictureUrl = fileName;
            }

            await _userManager.UpdateAsync(user);
            TempData["SuccessMessage"] = "Profile updated successfully!";
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordVM changePassword)
        {
            var user = await _userManager.GetUserAsync(User);
            if(user is null)
            {
                return RedirectToAction("Login", "Account");
            }

            var result = await _userManager.ChangePasswordAsync(user,changePassword.OldPassword,changePassword.NewPassword);

            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = "Password changed successfully!";
                return RedirectToAction("Index");
            }

            foreach(var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View(changePassword);
        }
    }
}
