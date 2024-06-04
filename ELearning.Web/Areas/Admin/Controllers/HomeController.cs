using ELearning.Business.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ELearning.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class HomeController : Controller
    {

        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IUserService _userService;

        public HomeController(IHttpContextAccessor httpContextAccessor, IUserService userService)
        {
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Trang chủ";
            return View();
        }
    }
}
