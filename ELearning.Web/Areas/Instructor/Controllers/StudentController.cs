using Microsoft.AspNetCore.Mvc;

namespace ELearning.Web.Areas.Instructor.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
