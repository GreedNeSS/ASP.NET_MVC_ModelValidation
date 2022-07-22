using System.ComponentModel.DataAnnotations;
using _5_CreatingValidation.Validation;

namespace _5_CreatingValidation.Models
{
    [NamePasswordEqual]
    public class Person : IValidatableObject
    {
        [PersonName(new string[]{"Admin", "admin"})]
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public int Age { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var errors = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(Name))
            {
                errors.Add(new ValidationResult("Введите имя!", new List<string> { "Name" }));
            }

            if (Age < 0 || Age > 110)
            {
                errors.Add(new ValidationResult("Недопустимый возраст!"));
            }

            return errors;
        }
    }
}
