using Microsoft.AspNetCore.Mvc;

namespace ELearning.Web.Areas.Student.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register()
        {
            return View();
        }
    }
}
