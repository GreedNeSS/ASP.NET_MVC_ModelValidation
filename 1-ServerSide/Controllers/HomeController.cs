using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using _1_ServerSide.Models;

namespace _1_ServerSide.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (person.Name == "admin" && person.Age == 25)
            {
                ModelState.AddModelError("", "Некорректные данные");
            }

            if (person.Age < 0 || person.Age > 110)
            {
                ModelState.AddModelError("Age", "Возраст должен находить в диапозоне от 0 до 110");
            }

            if (ModelState.IsValid)
            {
                person.Id = Guid.NewGuid();
                return Content($"Пользователь:\nId: {person.Id}\nName: {person.Name};\nAge: {person.Age}");
            }

            string errorMessages = "";

            foreach (var item in ModelState)
            {
                if (item.Value.ValidationState == ModelValidationState.Invalid)
                {
                    errorMessages += $"Ошибки для свойства: {item.Key}:\n";

                    foreach (var error in item.Value.Errors)
                    {
                        errorMessages += $"{error.ErrorMessage}\n";
                    }
                }
            }

            return Content(errorMessages);
        }
    }
}
