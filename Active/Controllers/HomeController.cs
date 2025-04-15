using System.Diagnostics;
using Active.Models;
using Microsoft.AspNetCore.Mvc;

namespace Active.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET: /Home/Contact
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        // POST: /Home/Contact
        [HttpPost]
        public IActionResult Contact(Message usermessage, string ElapsedTime)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Elapsed = ElapsedTime;
                return View(usermessage);
            }
            else
            {
                return View(usermessage); // ошибки валидации покажутся, ViewBag.Elapsed не нужен
            }
        }

        // GET: /Home/Order
        public IActionResult Order()
        {
            return View();
        }

        // AJAX: Set city
        [HttpPost]
        public JsonResult SetCity(string city)
        {
            try
            {
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddMinutes(1);
                Response.Cookies.Append("city", city);
                return Json(city);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        // GET: /Home/Game
        public IActionResult Game()
        {
            var model = new GuessNumberModel(); // Создаем экземпляр модели
            return View(model); // Передаем модель в представление
        }

        // POST: /Home/Game
        [HttpPost]
        public IActionResult Game(GuessNumberModel model)
        {
            if (ModelState.IsValid)
            {
                model.OnPost(); // Обрабатываем действия пользователя
                return View(model); // Возвращаем обновленную модель в представление
            }
            return View(model); // В случае ошибки валидации возвращаем модель
        }



    }
}
