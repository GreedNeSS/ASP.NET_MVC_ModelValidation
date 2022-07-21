using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _4_TagHelpers.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Поле обязательно к заполнению")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Длинна имени должна быть от 2 до 30 символов")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Поле обязательно к заполнению")]
        [EmailAddress(ErrorMessage = "Некорректный адрес")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Поле обязательно к заполнению")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Поле обязательно к заполнению")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [NotMapped]
        public string? PasswordConfirm { get; set; }

        [Range(0, 110, ErrorMessage = "Возраст должен находить в диапозоне от 0 до 110")]
        public int Age { get; set; }
    }
}
