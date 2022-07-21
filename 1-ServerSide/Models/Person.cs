using System.ComponentModel.DataAnnotations;

namespace _1_ServerSide.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string? Name { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
