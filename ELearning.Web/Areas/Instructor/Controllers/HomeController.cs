using Microsoft.AspNetCore.Mvc;

namespace ELearning.Web.Areas.Instructor.Controllers
{
    [Area("Instructor")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
