using System.ComponentModel.DataAnnotations;

namespace _6_DataAnnotation.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Поле обязательно к заполнению!")]
        [Display(Name = "Имя и фамилия")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Поле обязательно к заполнению!")]
        [Display(Name = "Электронная почта")]
        [UIHint("EmailAddress")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Поле обязательно к заполнению!")]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Поле обязательно к заполнению!")]
        [Display(Name = "Дата рождения")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
    }
}
