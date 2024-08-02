using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace MVC_Project.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        [StringLength(50)]
        public string DeptName { get; set; }
        public string Manager { get; set; }
        public ICollection<Trainee> Trainees { get; set; } = new List<Trainee>();
        public ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
