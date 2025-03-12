using Microsoft.AspNetCore.Mvc;

namespace Active.Controllers {
    public class ServicesController : Controller {
        public IActionResult Index()
        {
            return View();
        }
    }
}
