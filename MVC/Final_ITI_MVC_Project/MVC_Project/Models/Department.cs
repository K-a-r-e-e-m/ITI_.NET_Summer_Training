using MVC_Project.Validators;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace MVC_Project.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        [UniqueName]
        [MinLength(2, ErrorMessage = "Name must be grater than 1 letters")]
        [MaxLength(50, ErrorMessage = "Name must be less than 25 letters")]
        public string DeptName { get; set; }
        public string Manager { get; set; }
        public ICollection<Trainee> Trainees { get; set; } = new List<Trainee>();
        public ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
