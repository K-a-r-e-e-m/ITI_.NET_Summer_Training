using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    public class BindingController : Controller
    {
        public IActionResult Premitive(int x, int id, string name)
        {
            return Content("Hello");
        }  
        public IActionResult Complex(Department dept)
        {
            return Content("Hello");
        }
    }
}
