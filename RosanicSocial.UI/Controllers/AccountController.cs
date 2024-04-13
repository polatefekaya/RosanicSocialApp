﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RosanicSocial.Domain.DTO;
using RosanicSocial.Domain.IdentityEntities;

namespace RosanicSocial.UI.Controllers {
    [Route("[action]")]
    public class AccountController : Controller {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager) {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index() {
            return View();
        }
        public IActionResult Login() {
            return View();
        }
        [HttpGet]
        public IActionResult Register() {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDTO registerDTO) {
            if(!ModelState.IsValid) { 
                ViewBag.Errors = ModelState.Values.SelectMany(x => x.Errors).Select(temp => temp.ErrorMessage);
                return View(registerDTO);
            }
            ApplicationUser user = new ApplicationUser() {
                Email = registerDTO.Email,
                FirstName = registerDTO.FirstName,
                LastName = registerDTO.LastName,
                UserName = registerDTO.UserName
            };

            IdentityResult result = await _userManager.CreateAsync(user);
            if (result.Succeeded) {

                await _signInManager.SignInAsync(user, isPersistent: false);

                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

            foreach(IdentityError error in result.Errors) {
                ModelState.AddModelError("Error", error.Description);
            }
            return View(registerDTO);
        }
    }
}
