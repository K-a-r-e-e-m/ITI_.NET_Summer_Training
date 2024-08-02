using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Project.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Image { get; set; }
        public string? Address { get; set; }
        public int Grade { get; set; }
        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        public Department Department { get; set; }
    }
}
