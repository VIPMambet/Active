﻿using Active.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Active.Controllers {
    public class AccountController : Controller {

        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login(string returnUrl)
        {
            TempData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login userLogin)
        {
            var user = await _userManager.FindByEmailAsync(userLogin.Email);

            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, userLogin.Password, false, false);
                if (result.Succeeded)
                {
                    if (TempData["ReturnUrl"] != null)
                    {
                        return Redirect(TempData["ReturnUrl"].ToString());
                    }
                    return RedirectToAction("Index", "Home"); // или на главную
                }
                ModelState.AddModelError(string.Empty, "Неверный пароль.");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Пользователь не найден.");
            }

            return View(userLogin);
        }

        public  async Task <IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");

        }

        public async Task<IActionResult> AddUser()
        {
            AppUser user = new AppUser
            {
                UserName = "admin",
                Email = "gersen.e.a@gmail.com"
            };
            var result = await _userManager.CreateAsync(user, "Gg110188@");

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View();
            }
        }
    }
}
