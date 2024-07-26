using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_EF_Lab.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Instructor_Course> Instructor_Courses { get; set; }
        public virtual List<Student_Course> Student_Courses { get; set; }

    }
}
