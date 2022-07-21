using System.ComponentModel.DataAnnotations;

namespace _2_ClientSide.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения!")]
        [MaxLength(20, ErrorMessage = "Превышено максимальное количество символов (20)")]
        [MinLength(2, ErrorMessage = "Минимальное количество символов (2)")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения!")]
        [Range(0,110, ErrorMessage = "Возраст должен находить в диапозоне от 0 до 110")]
        public int Age { get; set; }
    }
}
