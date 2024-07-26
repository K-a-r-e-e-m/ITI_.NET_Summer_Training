using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_EF_Lab.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int? Age { get; set; }
        public decimal? Salary { get; set; }
        public virtual List<Instructor_Course> Instructor_Courses { get; set; } = new List<Instructor_Course>();

    }
}
