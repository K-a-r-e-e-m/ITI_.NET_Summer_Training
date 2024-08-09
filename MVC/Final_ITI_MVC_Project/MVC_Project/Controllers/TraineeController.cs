using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Project.Context;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{

    public class TraineeController : Controller
    {
        SchoolContext db = new SchoolContext();
        public ActionResult GetAll()
        {
            var res = db.Trainees.ToList();
            return View(res);
        }

        public IActionResult Details(int id)
        {
            var res = db.Trainees.Include("Department").FirstOrDefault(e => e.Id == id);
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
        public IActionResult Save(Trainee tran)
        {
            if (ModelState.IsValid)
            {
                db.Trainees.Add(tran);
                db.SaveChanges();
                //return View("GetAll", db.Trainees.ToList());
                return RedirectToAction("GetAll");
            }
            else
            {
                var depts = db.Departments.ToList();
                ViewBag.Dept = depts;
                return View("New", tran);
            }

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var emp = db.Trainees.FirstOrDefault(t => t.Id == id);
            return View(emp);
        }
        [HttpPost]
        public IActionResult EditSave(Trainee tran, int id)
        {
            //If we don't use update
            //var OldDept = db.Trainees.FirstOrDefault(d => d.Id == id);
            //OldDept.DeptName = tran.DeptName;
            //OldDept.Manager = tran.Manager;
            if (ModelState.IsValid)
            {
                db.Trainees.Update(tran);
                db.SaveChanges();
                return RedirectToAction("GetAll");
            }
            return View("Edit", tran);
        }
        public IActionResult Delete(int id)
        {
            var tran = db.Trainees.FirstOrDefault(d => d.Id == id);
            var t = db.CrsResults.FirstOrDefault(c => c.TraineeID == id);
            if ( t != null )
            {
                return View();
            }

            db.Trainees.Remove(tran);
            db.SaveChanges();
            return RedirectToAction("GetAll");
        }
    }
}
