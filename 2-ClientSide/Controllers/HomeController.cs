using Microsoft.AspNetCore.Mvc;
using _2_ClientSide.Models;

namespace _2_ClientSide.Controllers
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
            if (ModelState.IsValid)
            {
                person.Id = Guid.NewGuid();
                return Content($"Person Info:\nId: {person.Id}\nName: {person.Name}\nAge: {person.Age}");
            }

            return View(person);
        }
    }
}
