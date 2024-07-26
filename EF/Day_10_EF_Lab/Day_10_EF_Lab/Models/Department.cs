using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_EF_Lab.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public List<Student> Employees { get; set; } = new List<Student>();

        public override string ToString() => $"{DeptName}";
    }
}
