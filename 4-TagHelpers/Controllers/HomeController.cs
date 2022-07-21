using _4_TagHelpers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _4_TagHelpers.Controllers
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
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (person.Name == person.Email)
            {
                ModelState.AddModelError("", "Имя и Email не должны совпадать");
            }

            if (string.Equals(person.Name, "admin", StringComparison.OrdinalIgnoreCase))
            {
                ModelState.AddModelError("", "Это имя является забронированным");
            }
            Console.WriteLine("1");

            if (ModelState.IsValid)
            {
                return View("Index", person);
            }
            return View(person);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}