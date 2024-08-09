using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MVC_Project.Validators;

namespace MVC_Project.Models
{
    public class Course
    {
        [Key]
        public int CrsId { get; set; }
        [Required]
        [UniqueName]
        [MinLength(4, ErrorMessage = "Name must be grater than 3 letters")]
        [MaxLength(25, ErrorMessage = "Name must be less than 25 letters")]
        public string CrsName { get; set; }
        public double Degree { get; set; }
        public int MinDegree { get; set; }
        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        public Department Department { get; set; }
    }
}
