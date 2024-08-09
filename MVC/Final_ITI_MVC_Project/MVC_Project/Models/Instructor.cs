using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MVC_Project.Validators;

namespace MVC_Project.Models
{
    public class Instructor
    {
        [Key]
        public int InstId { get; set; }
        [Required]
        [UniqueName]
        [MinLength(4, ErrorMessage = "Name must be grater than 3 letters")]
        [MaxLength(25, ErrorMessage = "Name must be less than 25 letters")]
        public string InstName { get; set; }
        public string? Image { get; set; }
        [Range(10000, 50000)]

        public double? Salary { get; set; }
        public string? Address { get; set; }

        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        public Department Department { get; set; }

        [ForeignKey("Course")]
        public int? CrsId { get; set; }
        public Course Course { get; set; }

    }
}
