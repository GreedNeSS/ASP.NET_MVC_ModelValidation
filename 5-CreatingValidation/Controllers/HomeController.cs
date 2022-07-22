using Microsoft.AspNetCore.Mvc;
using _5_CreatingValidation.Models;

namespace _5_CreatingValidation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            Console.WriteLine("1");
            if (ModelState.IsValid)
            {
                return Json(person);
            }

            return View();
        }
    }
}
