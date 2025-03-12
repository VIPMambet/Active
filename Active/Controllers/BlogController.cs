using Microsoft.AspNetCore.Mvc;

namespace Active.Controllers {
    public class BlogController : Controller {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Blog/Blog-details")]
        public IActionResult BlogDetails()
        {
            return View("Blog-details");
        }
    }
}
