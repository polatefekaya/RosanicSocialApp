using Microsoft.AspNetCore.Mvc;

namespace RosanicSocial.UI.Controllers {
    public class ProfileController : Controller {
        [Route("profile")]
        public IActionResult Profile() {
            return View();
        }
    }
}
