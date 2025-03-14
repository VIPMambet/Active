using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Active.Controllers {
    public class TeamController : Controller {

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
