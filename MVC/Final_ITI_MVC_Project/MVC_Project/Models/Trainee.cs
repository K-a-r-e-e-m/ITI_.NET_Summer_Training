using Microsoft.AspNetCore.Mvc;
using MVC_Project.Validators;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Project.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        [UniqueName]
        [MinLength(4, ErrorMessage = "Name must be grater than 3 letters")]
        [MaxLength(25, ErrorMessage = "Name must be less than 25 letters")]
        public string Name { get; set; }
        public string? Image { get; set; }
        [DisplayName("Address")]
        [RegularExpression("[a-zA-Z]{4,25}", ErrorMessage = "Address must be only letters and between 4 and 25 letters")]
        public string? Address { get; set; }
        [Range(0, 100)]
        public int Grade { get; set; }
        [ForeignKey("Department")]
        [DisplayName("Department")]
        public int? DeptId { get; set; }
        public Department? Department { get; set; }
    }
}
