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

        //GET
        public JsonResult SetCity(string city) 
        {
            try
            {
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddMinutes(1);
                Response.Cookies.Append("city",city);
                return Json(city);
            }
            catch (Exception ex) 
            {
                return Json(ex.Message);
            }
        
        
        }


    }
}
