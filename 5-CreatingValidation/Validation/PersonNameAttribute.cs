using System.ComponentModel.DataAnnotations;

namespace _5_CreatingValidation.Validation
{
    public class PersonNameAttribute : ValidationAttribute
    {
        string[] _names;

        public PersonNameAttribute(string[] names)
        {
            _names = names;
            ErrorMessage = "Введено недопустипое имя";
        }

        public override bool IsValid(object? value)
        {
            return value != null && !_names.Contains(value);
        }
    }
}
