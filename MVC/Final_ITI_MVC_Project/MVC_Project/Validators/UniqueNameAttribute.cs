using Microsoft.AspNetCore.Components.Forms;
using MVC_Project.Context;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Validators
{
    public class UniqueNameAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string name = value as string;
            SchoolContext db = new SchoolContext();
            var tran = db.Trainees.FirstOrDefault(t => t.Name == name);
            if (tran == null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Name already exists!");
        }
    }
}
