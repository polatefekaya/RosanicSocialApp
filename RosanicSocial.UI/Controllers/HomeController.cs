using Microsoft.AspNetCore.Mvc;

namespace RosanicSocial.UI.Controllers {
    public class HomeController : Controller {
        [Route("/")]
        public IActionResult Index() {
            return View();
        }
    }
}
