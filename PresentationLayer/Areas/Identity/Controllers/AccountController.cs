using CoreLayer.Utility;
using DataAccessLayer.Data;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using PresentationLayer.ViewModels;

namespace PresentationLayer.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IUnitOfWork _unitOfWork;
        public AccountController(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager, IEmailSender _emailSender, RoleManager<IdentityRole> roleManager, IUnitOfWork unitOfWork)
        {
            this._userManager = _userManager;
            this._signInManager = _signInManager;
            this._emailSender = _emailSender;
            _roleManager = roleManager;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var existingUser = await _userManager.FindByEmailAsync(model.Email) ??
                       await _userManager.FindByNameAsync(model.UserName);
            if(existingUser !=  null)
            {
                ModelState.AddModelError(string.Empty, "User with this email or username already exists.");
                return View(model);
            }

            var user = new ApplicationUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email,
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, SD.Customer);
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var confirmationLink = Url.Action(nameof(ConfirmEmail), "Account", new { userId = user.Id, token = token }, Request.Scheme);
                await _emailSender.SendEmailAsync(model.Email, "Confirm your email", $"Please confirm your account by clicking this link: <a href='{confirmationLink}'>link</a>");
                return RedirectToAction(nameof(ConfirmEmailPage), "Account", new { userId = user.Id, area = "Identity" });
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(model);
            }

        }

        public async Task<IActionResult> ConfirmEmailPage(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null || user?.EmailConfirmed == true)
            {
                return NotFound();
            }
            return View();
        }
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }
            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = "Confirmed successfully.";
                var sessionId = GetSessionId();
                var existingCarts = await _unitOfWork.CartRepository.GetAllAsync(c => c.SessionId == sessionId);
                if (existingCarts != null)
                {
                    foreach (var cart in existingCarts)
                    {
                        cart.UserId = user.Id;
                        cart.SessionId = null;
                        _unitOfWork.CartRepository.Update(cart);
                    }
                    await _unitOfWork.CartRepository.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Login));
            }
            else
            {
                TempData["error"] = "Not Confirmed";
                return RedirectToAction(nameof(Register));
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.UserNameOrEmail) ??
                       await _userManager.FindByNameAsync(model.UserNameOrEmail);

            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "User Name Or Email is InValid");
                return View(model);
            }
            var result = await _userManager.CheckPasswordAsync(user, model.Password);
            if (result)
            {
                if (!user.EmailConfirmed)
                {
                    ModelState.AddModelError(string.Empty, "Email is not confirmed. Please check your email for confirmation link.");
                    return View(model);
                }
                await _signInManager.SignInAsync(user, model.RememberMe);
                // Merge Guest Cart with User Cart
                var sessionId = GetSessionId();
                var existingCarts = await _unitOfWork.CartRepository.GetAllAsync(c => c.SessionId == sessionId);
                if (existingCarts != null) 
                {
                    foreach(var cart in existingCarts)
                    {
                        cart.UserId = user.Id;
                        cart.SessionId = null;
                         _unitOfWork.CartRepository.Update(cart);
                    }
                    await _unitOfWork.CartRepository.SaveChangesAsync();
                }
                var roles = await _userManager.GetRolesAsync(user);
                if (roles.Contains("SuperAdmin") || roles.Contains("Admin"))
                {
                    return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "Customer" });
                }

            }
            else
            {
                ModelState.AddModelError(string.Empty, "Password is InValid");
                return View(model);
            }
        }

        private string GetSessionId()
        {
            const string cookieName = "GuestSessionId";
            if (!Request.Cookies.TryGetValue(cookieName, out var sessionId))
            {
                sessionId = Guid.NewGuid().ToString();
                Response.Cookies.Append(cookieName, sessionId, new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddDays(30),
                    HttpOnly = true,
                    IsEssential = true
                });
            }
            return sessionId;
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new { area = "Customer" });
        }


        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordVM forgetPasswordVM)
        {
            if (!ModelState.IsValid)
            {
                return View(forgetPasswordVM);
            }

            var user = await _userManager.FindByEmailAsync(forgetPasswordVM.EmailOrUserName);

            if (user is null)
            {
                user = await _userManager.FindByNameAsync(forgetPasswordVM.EmailOrUserName);
            }

            if (user is not null)
            {
                // Send Confirmation Email
                var otpNumber = new Random().Next(1000, 9999);

                var totalNumberOfOTPs = (await _unitOfWork.ApplicationUserOTPRepository.GetAllAsync(e => e.ApplicationUserId == user.Id && DateTime.UtcNow.Day == e.SendDate.Day));

                if (totalNumberOfOTPs.Count() > 5)
                {
                    TempData["error-notification"] = "Many Requests of OTPs";
                    return View(forgetPasswordVM);
                }

                await _unitOfWork.ApplicationUserOTPRepository.AddAsync(new()
                {
                    ApplicationUserId = user.Id,
                    OTPNumber = otpNumber,
                    Reason = "ForgetPassword",
                    SendDate = DateTime.UtcNow,
                    Status = false,
                    ValidTo = DateTime.UtcNow.AddMinutes(30)
                });

                await _emailSender.SendEmailAsync(user!.Email ?? "", "OTP Your Account", $"<h1>Reset Password using OTP: {otpNumber}</h1>");

                TempData["success-notification"] = "Send OTP to your Email Successfully";

                TempData["Redirection"] = Guid.NewGuid();

                return RedirectToAction("ResetPassword", "Account", new { area = "Identity", userId = user.Id });
            }

            return View(forgetPasswordVM);
        }

        public async Task<IActionResult> ResetPassword(string userId)
        {

            var user = await _userManager.FindByIdAsync(userId);

            if (user is not null)
            {
                return View(new ResetPasswordVM()
                {
                    UserId = userId
                });
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM resetPasswordVM)
        {
            if (!ModelState.IsValid)
            {
                return View(resetPasswordVM);
            }

            var user = await _userManager.FindByIdAsync(resetPasswordVM.UserId);

            if (user is not null)
            {
                var lastOTP = (await _unitOfWork.ApplicationUserOTPRepository.GetAllAsync(e => e.ApplicationUserId == resetPasswordVM.UserId)).OrderBy(e => e.Id).LastOrDefault();

                if (lastOTP is not null)
                {
                    if (lastOTP.OTPNumber == resetPasswordVM.OTP && (lastOTP.ValidTo - DateTime.UtcNow).TotalMinutes < 30 && !lastOTP.Status)
                    {
                        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                        var result = await _userManager.ResetPasswordAsync(user, token, resetPasswordVM.Password);

                        if (result.Succeeded)
                        {
                            TempData["success-notification"] = "Reset Password Successfully";
                        }
                        else
                        {
                            TempData["error-notification"] = $"{String.Join(",", result.Errors)}";
                        }

                        return RedirectToAction("Index", "Home", new { area = "Customer" });
                    }
                }

                TempData["error-notification"] = "Invalid OR Expired OTP";
                return View(resetPasswordVM);
            }

            return NotFound();
        }
    }
}
