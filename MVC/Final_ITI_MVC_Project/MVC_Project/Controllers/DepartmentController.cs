using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Project.Context;
using MVC_Project.Models;
using MVC_Project.ViewModels;

namespace MVC_Project.Controllers
{
    public class DepartmentController : Controller
    {
        SchoolContext db = new SchoolContext();

        public IActionResult New()
        {
            return View();
        }
        public IActionResult Save(Department dept)
        {
            if (ModelState.IsValid)
            {
                db.Departments.Add(dept);
                db.SaveChanges();
                //return View("Index", db.Departments.ToList());
                return RedirectToAction("Index");
            }
            return View("New", dept);
        }
        public IActionResult Index()
        {
            var depts = db.Departments.ToList();
            return View(depts);
        }

        public IActionResult Details(int id)
        {
            var depts = db.Departments.Include(t => t.Trainees).FirstOrDefault(d => d.DeptId == id);
            return View(depts);
        }
        public IActionResult DeptWithBranches(int id)
        {
            var depts = db.Departments.Include(t => t.Trainees).FirstOrDefault(d => d.DeptId == id);
            List<string> Branches = new List<string>
                {
                "Ismaillia",
                "Smart Village",
                "Mnofuea",
                "North Sinai"
                };

            ViewData["Brc"] = Branches;
            ViewData["Msg"] = "Hello";
            ViewData["Color"] = "Red";
            ViewBag.Msg = "Hello from ViewBag";
            return View(depts);

        }
        public IActionResult DeptWithBranchesVM(int id)
        {
            var depts = db.Departments.Include(t => t.Trainees).FirstOrDefault(d => d.DeptId == id);
            List<string> Branches = new List<string>
                {"Ismaillia", "Smart Village", "Mnofuea", "North Sinai"};

            DeptMsgColorWithBranchesVM deptVM = new DeptMsgColorWithBranchesVM();

            deptVM.Department = depts.DeptName;
            deptVM.Manager = depts.Manager;
            deptVM.Color = "Red";
            deptVM.Message = "Hello from View Model";
            deptVM.Branches = Branches;
            deptVM.TraineesNumber = depts.Trainees.Count;

            return View(deptVM);

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var emp = db.Departments.FirstOrDefault(t => t.DeptId == id);
            return View(emp);
        }
        [HttpPost]
        public IActionResult EditSave(Department dept, int id)
        {
            //If we don't use update
            //var OldDept = db.Departments.FirstOrDefault(d => d.DeptId == id);
            //OldDept.DeptName = dept.DeptName;
            //OldDept.Manager = dept.Manager;
            if (dept.DeptName != null && dept.Manager != null)
            {
                db.Departments.Update(dept);
                db.SaveChanges();
                return RedirectToAction("Index"); 
            }
            return View("Edit", dept);
        }
        public IActionResult Delete(int id)
        {
            var dept = db.Departments.FirstOrDefault(d => d.DeptId == id);
            var c = db.Courses.FirstOrDefault(c => c.DeptId == id);
            var t = db.Trainees.FirstOrDefault(c => c.DeptId == id);
            var i = db.Instructors.FirstOrDefault(c => c.DeptId == id);
            if (c != null || t != null || i != null) 
            { 
                return View();
            }
            db.Departments.Remove(dept);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
