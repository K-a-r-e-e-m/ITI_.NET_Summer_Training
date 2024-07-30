using System.ComponentModel.DataAnnotations;

namespace MVC_Lab1.Models
{
    public class Student
    {
        [Key]
        public int SSN { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Address { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
