using Microsoft.AspNetCore.Mvc;

namespace Active.Controllers {
    public class TeamController : Controller {
        public IActionResult Index()
        {
            return View();
        }
    }
}
