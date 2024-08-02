using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models
{
    public class Instructor
    {
        [Key]
        public int InstId { get; set; }
        [Required]
        public string InstName { get; set; }
        public string? Image { get; set; }
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
