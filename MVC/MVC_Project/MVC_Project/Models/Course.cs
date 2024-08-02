using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models
{
    public class Course
    {
        [Key]
        public int CrsId { get; set; }
        [Required]
        public string CrsName { get; set; }
        public double Degree { get; set; }
        public int MinDegree { get; set; }
        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        public Department Department { get; set; }
    }
}
