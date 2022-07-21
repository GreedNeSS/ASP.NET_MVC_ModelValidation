using _3_ValidationAttributes.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace _3_ValidationAttributes.Controllers
{
    public class HomeController : Controller
    {
        List<string> emails = new()
        {
            "admin@mail.ru",
            "aaa@mail.ru"
        };

        [AcceptVerbs("Post", "Get")]
        public IActionResult CheckEmail(string email)
        {
            if (emails.Contains(email))
            {
                return Json(false);
            }

            return Json(true);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                return Json(person);
            }
            return View(person);
        }
    }
}
