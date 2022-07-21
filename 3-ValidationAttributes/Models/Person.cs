using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace _3_ValidationAttributes.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Поле обязательно к заполнению")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Длинна имени должна быть от 2 до 30 символов")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Поле обязательно к заполнению")]
        //[EmailAddress(ErrorMessage = "Некорректный адрес")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        [Remote(action: "CheckEmail", controller: "Home", ErrorMessage = "Email уже занят")]
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
