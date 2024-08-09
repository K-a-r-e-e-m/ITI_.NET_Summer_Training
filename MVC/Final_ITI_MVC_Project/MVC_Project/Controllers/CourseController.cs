using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Project.Context;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    public class CourseController : Controller
    {
        SchoolContext db = new SchoolContext();

        public ActionResult GetAll()
        {
            var res = db.Courses.ToList();
            return View(res);
        }

        public IActionResult Details(int id)
        {
            var res = db.Courses.Include("Department").FirstOrDefault(e => e.CrsId == id);
            return View(res);
        }
        [HttpGet]
        public IActionResult New()
        {
            var depts = db.Departments.ToList();
            ViewBag.Dept = depts;
            return View();
        }
        [HttpPost]
        public IActionResult Save(Course crs)
        {
            if (ModelState.IsValid)
            {
                db.Courses.Add(crs);
                db.SaveChanges();
                //return View("GetAll", db.Courses.ToList());
                return RedirectToAction("GetAll");
            }
            else
            {
                var depts = db.Departments.ToList();
                ViewBag.Dept = depts;
                return View("New", crs);
            }

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var emp = db.Courses.FirstOrDefault(t => t.CrsId == id);
            return View(emp);
        }
        [HttpPost]
        public IActionResult EditSave(Course crs, int id)
        {
            //If we don't use update
            //var OldDept = db.Courses.FirstOrDefault(d => d.CrsId == id);
            //OldDept.DeptCrsName = crs.DeptCrsName;
            //OldDept.Manager = crs.Manager;
            if (crs.CrsName != null)
            {
                db.Courses.Update(crs);
                db.SaveChanges();
                return RedirectToAction("GetAll");
            }
            return View("Edit", crs);
        }
        public IActionResult Delete(int id)
        {
            var crs = db.Courses.FirstOrDefault(d => d.CrsId == id);
            var t = db.CrsResults.FirstOrDefault(c => c.ResId == id);
            if (t != null)
            {
                return View();
            }

            db.Courses.Remove(crs);
            db.SaveChanges();
            return RedirectToAction("GetAll");
        }
    }
}
