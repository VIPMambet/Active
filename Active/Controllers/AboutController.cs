using Microsoft.AspNetCore.Mvc;

namespace Active.Controllers {
    public class AboutController : Controller {
        public IActionResult Index()
        {
            return View();
        }
    }
}
