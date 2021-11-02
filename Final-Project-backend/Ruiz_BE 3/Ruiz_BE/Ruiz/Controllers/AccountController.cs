using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Ruiz.DAL;
using Ruiz.Models;
using Ruiz.Services;
using Ruiz.ViewModels;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IEmailService _emailService;
        public AccountController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IEmailService emailService)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _emailService = emailService;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegisterViewModel registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (_userManager.Users.Any(x => x.NormalizedUserName == registerVM.UserName.ToUpper()))
            {
                ModelState.AddModelError("UserName", "UserName already taken!");
                return View();
            }

            if (_userManager.Users.Any(x => x.NormalizedEmail == registerVM.Email.ToUpper()))
            {
                ModelState.AddModelError("Email", "Email already taken!");
                return View();
            }

            AppUser appUser = new AppUser
            {
                UserName = registerVM.UserName,
                Email = registerVM.Email,
                FullName = registerVM.FullName,
                IsAdmin = false
            };

            IdentityResult result = await _userManager.CreateAsync(appUser, registerVM.Password);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View();
            }

            await _userManager.AddToRoleAsync(appUser, "Member");
            string token = await _userManager.GenerateEmailConfirmationTokenAsync(appUser);

            string body = string.Empty;

            using (StreamReader reader = new StreamReader("wwwroot/templates/emailverification.html"))
            {
                body = reader.ReadToEnd();
            }

            string callback = Url.Action("confirmemail", "account", new { token, email = appUser.Email }, Request.Scheme);
            body = body.Replace("{{fullname}}", appUser.FullName).Replace("{{url}}", callback);

            _emailService.Send(appUser.Email, "Confirm email", body);
            await _signInManager.SignInAsync(appUser, true);


            return RedirectToAction("index", "home");
        }

        public async Task<IActionResult> ConfirmEmail(string token, string email)
        {
            AppUser user = await _userManager.FindByEmailAsync(email);

            if (user == null) return NotFound();

            var result = await _userManager.ConfirmEmailAsync(user, token);

            if (!result.Succeeded) return NotFound();

            return RedirectToAction("login");
        }
        


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLoginViewModel loginVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser user = await _userManager.FindByNameAsync(loginVM.UserName);

            if (user == null || user.IsAdmin)
            {
                ModelState.AddModelError("", "Username or Password incorrect!");
                return View();
            }

            if (!user.EmailConfirmed)
            {
                ViewBag.Email = user.Email;
                return View("confirmemail");
            }

            var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, true, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Username or Password incorrect!");
                return View();
            }

            return RedirectToAction("index", "home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("index", "home");
        }

        [HttpPost]
        public async Task<IActionResult> SendConfirmEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return NotFound();

            AppUser appUser = await _userManager.FindByEmailAsync(email);

            if (appUser == null) return NotFound();

            string token = await _userManager.GenerateEmailConfirmationTokenAsync(appUser);

            string body = string.Empty;

            using (StreamReader reader = new StreamReader("wwwroot/templates/emailverification.html"))
            {
                body = reader.ReadToEnd();
            }

            string callback = Url.Action("confirmemail", "account", new { token, email = appUser.Email }, Request.Scheme);
            body = body.Replace("{{fullname}}", appUser.FullName).Replace("{{url}}", callback);

            _emailService.Send(appUser.Email, "Confirm email", body);

            return RedirectToAction("login");
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel forgotPasswordVM)
        {
            AppUser user = await _userManager.FindByEmailAsync(forgotPasswordVM.Email);

            if (user == null)
            {
                ModelState.AddModelError("Email", "Email is not valid!");
                return View();
            }

            string token = await _userManager.GeneratePasswordResetTokenAsync(user);
            string callback = Url.Action("resetpassword", "account", new { token, email = user.Email }, Request.Scheme);

            string body = string.Empty;

            using (StreamReader reader = new StreamReader("wwwroot/templates/forgotpassword.html"))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{{url}}", callback);


            _emailService.Send(user.Email, "Reset password!", body);

            return RedirectToAction("login");
        }


        public async Task<IActionResult> ResetPassword(string token, string email)
        {
            ResetPasswordViewModel resetPasswordVM = new ResetPasswordViewModel
            {
                Token = token,
                Email = email
            };
            return View(resetPasswordVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordVM)
        {
            if (!ModelState.IsValid) return View(resetPasswordVM);

            AppUser user = await _userManager.FindByEmailAsync(resetPasswordVM.Email);
            if (user == null) return NotFound();

            var resetResult = await _userManager.ResetPasswordAsync(user, resetPasswordVM.Token, resetPasswordVM.Password);

            if (!resetResult.Succeeded)
            {
                foreach (var item in resetResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(resetPasswordVM);
            }

            return RedirectToAction("login");
        }

        [Authorize(Roles = "Member")]
        public async Task<IActionResult> Edit()
        {
            
           
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateViewModel updateModel = new UserUpdateViewModel
            {
                Email = user.Email,
                FullName = user.FullName,
                UserName = user.UserName,
                Address1 = user.Address1,
                Address2 = user.Address2,
             
            };

            return View(updateModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Member")]
        public async Task<IActionResult> Edit(UserUpdateViewModel updateVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (user.UserName != updateVM.UserName && _userManager.Users.Any(x => x.NormalizedUserName == updateVM.UserName.ToUpper()))
            {
                ModelState.AddModelError("UserName", "Username already taken");
                return View();
            }

            if (user.Email != updateVM.Email && _userManager.Users.Any(x => x.NormalizedEmail == updateVM.Email.ToUpper()))
            {
                ModelState.AddModelError("Email", "Email already taken");
                return View();
            }

            if (!string.IsNullOrWhiteSpace(updateVM.Password))
            {
                if (updateVM.Password != updateVM.ConfirmPassword)
                {
                    ModelState.AddModelError("ConfirmPassword", "Password and Confirm password does not match!");
                    return View();
                }

                var result = await _userManager.ChangePasswordAsync(user, updateVM.CurrentPassword, updateVM.Password);

                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    return View();
                }

            }


            user.UserName = updateVM.UserName;
            user.Email = updateVM.Email;
            user.FullName = updateVM.FullName;
            user.Address1 = updateVM.Address1;
            user.Address2 = updateVM.Address2;

            await _userManager.UpdateAsync(user);
            await _signInManager.SignInAsync(user, true);


            return RedirectToAction("index", "home");
        }

       
    }
}
