using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RosanicSocial.UI.Controllers {
    public class HomeController : Controller {
        [Route("home")]
        public IActionResult Index() {
            return View();
        }

        [Route("/")]
        [AllowAnonymous]
        public IActionResult Landing() {
            return View();
        }
    }
}
