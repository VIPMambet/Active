using System.Diagnostics;
using Active.Models;
using Microsoft.AspNetCore.Mvc;

namespace Active.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact() 
        {
            return View();
        }

       
    }
}
