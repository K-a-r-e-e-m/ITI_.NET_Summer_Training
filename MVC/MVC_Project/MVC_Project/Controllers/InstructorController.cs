using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Project.Context;
using MVC_Project.ViewModels;

namespace MVC_Project.Controllers
{
    public class InstructorController : Controller
    {
        SchoolContext db = new SchoolContext();
        public IActionResult GetAll()
        {
            var depts = db.Instructors.ToList();
            return View(depts);
        }

        public IActionResult Details(int id)
        {
            var depts = db.Instructors
                .Include(d => d.Department)
                .Include(c => c.Course)
                .FirstOrDefault(d => d.InstId == id);

            return View(depts);

        }
    }
}
