using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Ruiz.Areas.Manage.ViewModels;
using Ruiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AccountController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AdminLoginViewModel loginVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser admin = await _userManager.FindByNameAsync(loginVM.UserName);

            if (admin == null || !admin.IsAdmin)
            {
                ModelState.AddModelError("", "Username or Password is incorrect!");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(admin, loginVM.Password, true, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Username or password incorrect!");
                return View();
            }

            return RedirectToAction("index", "dashboard");
        }
    }

}
