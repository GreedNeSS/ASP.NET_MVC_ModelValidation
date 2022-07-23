using Microsoft.AspNetCore.Mvc;
using _6_DataAnnotation.Models;
using System;

namespace _6_DataAnnotation.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index(Person? person)
        {
            if (person == null)
            {
                return View();
            }

            return View(person);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            return RedirectToAction("Index", person);
        }
    }
}
