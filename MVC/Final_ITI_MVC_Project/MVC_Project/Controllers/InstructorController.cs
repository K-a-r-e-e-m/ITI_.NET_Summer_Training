using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Project.Context;
using MVC_Project.Models;
using MVC_Project.ViewModels;

namespace MVC_Project.Controllers
{
    public class InstructorController : Controller
    {
        SchoolContext db = new SchoolContext();
        public IActionResult GetAll()
        {
            var insts = db.Instructors.ToList();
            return View(insts);
        }

        public IActionResult New()
        {
            return View();
        }
        public IActionResult Save(Instructor inst)
        {
            if (ModelState.IsValid)
            {
                db.Instructors.Add(inst);
                db.SaveChanges();
                //return View("GetAll", db.Instructors.ToList());
                return RedirectToAction("GetAll");
            }
            return View("New", inst);
        }
        public IActionResult Details(int id)
        {
            var insts = db.Instructors.FirstOrDefault(d => d.InstId == id);

            return View(insts);

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var emp = db.Instructors.FirstOrDefault(t => t.InstId == id);
            return View(emp);
        }
        [HttpPost]
        public IActionResult EditSave(Instructor inst, int id)
        {
            //If we don't use update
            //var OldDept = db.Instructors.FirstOrDefault(d => d.InstId == id);
            //OldDept.InstName = inst.InstName;
            //OldDept.Salary = inst.Salary;
            if (inst.InstName != null && inst.Salary != null && inst.Address != null)
            {
                db.Instructors.Update(inst);
                db.SaveChanges();
                return RedirectToAction("GetAll");
            }
            return View("Edit", inst);
        }
        public IActionResult Delete(int id)
        {
            var inst = db.Instructors.FirstOrDefault(d => d.InstId == id);
            db.Instructors.Remove(inst);
            db.SaveChanges();
            return RedirectToAction("GetAll");
        }
    }
}
