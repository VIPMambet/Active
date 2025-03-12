using Microsoft.AspNetCore.Mvc;

namespace Active.Controllers {
    public class PortfolioController : Controller {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Portfolio/Portfolio-details")]
        public IActionResult PortfolioDetails()
        {
            return View("Portfolio-details");
        }
    }
}
