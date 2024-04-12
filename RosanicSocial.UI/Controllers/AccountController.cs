using Microsoft.AspNetCore.Mvc;
using RosanicSocial.Domain.DTO;

namespace RosanicSocial.UI.Controllers {
    [Route("[action]")]
    public class AccountController : Controller {
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
        public IActionResult Register(RegisterDTO registerDTO) {
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
