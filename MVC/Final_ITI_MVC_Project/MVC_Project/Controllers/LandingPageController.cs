using Microsoft.AspNetCore.Mvc;

namespace MVC_Project.Controllers
{
    public class LandingPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
