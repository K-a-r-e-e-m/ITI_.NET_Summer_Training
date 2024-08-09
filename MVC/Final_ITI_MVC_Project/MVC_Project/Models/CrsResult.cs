using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models
{
    public class CrsResult
    {
        [Key]
        public int ResId { get; set; }
        public string ResDegree { get; set; }
       
        [ForeignKey("Course")]
        public int? CrsId { get; set; }
        public Course Course { get; set; }
        
        [ForeignKey("Trainee")]
        public int? TraineeID { get; set; }
        public Trainee Trainee { get; set; }
    }
}
