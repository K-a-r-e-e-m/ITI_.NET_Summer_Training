using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_EF_Lab.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        public Department Department { get; set; }
        public virtual List<Student_Course> Student_Courses { get; set; } = new List<Student_Course>();
        public override string ToString() => $"{Name} {Age} {Department}";

    }
}
