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
        [HttpGet]
        public IActionResult Contact() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Message usermessage)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Contact"); // Перенаправление на Contact после успешной отправки
            }
            else
            {
                return View("Contact", usermessage); // Остаёмся на Contact с отображением ошибок
            }
        }




    }
}
