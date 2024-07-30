using Microsoft.AspNetCore.Mvc;
using MVC_Lab1.Context;

namespace MVC_Lab1.Controllers
{
    public class StudentController : Controller
    {
        SchoolContext db = new SchoolContext();

        public ActionResult GetAll()
        {
            var res = db.Students.ToList();
            return View(res);
        }

        public IActionResult GetById(int id)
        {
            var res = db.Students.FirstOrDefault(e => e.SSN == id);
            return View(res);
        }


        #region Actions
        //public ContentResult First()
        //{
        //    ContentResult res = new ContentResult();
        //    res.Content = "Hellow from first action";
        //    return res;
        //}
        //public ViewResult Second()
        //{
        //    ViewResult res = new ViewResult();
        //    res.ViewName = "Test";
        //    return res;
        //}

        //public ActionResult Mix()
        //{
        //    int x = 11;
        //    if (x % 2 == 0)
        //        return Content("Hello from mix action");
        //    return View("Test");
        //} 
        #endregion
    }
}
