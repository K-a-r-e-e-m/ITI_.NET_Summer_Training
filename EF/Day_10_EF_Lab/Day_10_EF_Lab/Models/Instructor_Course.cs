using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_EF_Lab.Models
{
    public class Instructor_Course
    {
        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
