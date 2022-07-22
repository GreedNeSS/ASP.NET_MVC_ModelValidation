using System.ComponentModel.DataAnnotations;
using _5_CreatingValidation.Models;

namespace _5_CreatingValidation.Validation
{
    public class NamePasswordEqualAttribute : ValidationAttribute
    {
        public NamePasswordEqualAttribute()
        {
            ErrorMessage = "Имя и пароль не должны совпадать";
        }

        public override bool IsValid(object? value)
        {
            Person? person = value as Person;
            return person != null && person.Name != person.Password;
        }
    }
}
