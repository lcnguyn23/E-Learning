using Microsoft.AspNetCore.Mvc;

namespace ELearning.Web.Areas.Instructor.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register()
        {
            return View();
        }
    }
}
