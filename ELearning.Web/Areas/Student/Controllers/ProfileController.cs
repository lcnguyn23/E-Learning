using ELearning.Business.Services.Interfaces;
using ELearning.Data;
using ELearning.DomainModels.User;
using ELearning.Web.Areas.Instructor.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ELearning.Web.Areas.Student.Controllers
{
    [Authorize(Roles = "Student")]
    [Area("Student")]
    public class ProfileController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IUserService _userService;
        private readonly ILogger<CourseController> _logger;

        private readonly ELearningDbContext _context;

        public ProfileController(IHttpContextAccessor httpContextAccessor, IUserService userService, ILogger<CourseController> logger, ELearningDbContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var currentUserEmail = _httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(p => p.Type.Contains("email")).Value;
            var currentUser = await _userService.GetUserByEmailAsync(currentUserEmail);

            if (currentUser == null)
            {
                return RedirectToAction("Login", "Account");
            }

            ViewBag.Title = "";
            return View(currentUser);
        }


        public async Task<IActionResult> Security()
        {
            ViewBag.Title = "";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Security(ApplicationUser user)
        {
            return View();
        }
    }
}
