using ELearning.Business.Services.Interfaces;
using ELearning.Data;
using ELearning.DomainModels.User;
using ELearning.Web.Areas.Instructor.Controllers;
using ELearning.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ELearning.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class UserManageController : Controller
    {

        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IUserService _userService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<CourseController> _logger;

        private readonly ELearningDbContext _context;

        

        public UserManageController(IHttpContextAccessor httpContextAccessor, IUserService userService, UserManager<ApplicationUser> userManager, ILogger<CourseController> logger, ELearningDbContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
            _userManager = userManager;
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            var userList = await _userService.GetAllUsersAsync();
            
            var list = new List<UserListViewModel>();
            foreach (var user in userList)
            {
                var role = await _userManager.GetRolesAsync(user);
                var en = new UserListViewModel()
                {
                    Id = user.Id,
                    Name = user.FullName,
                    Email = user.Email,
                    Role = role[0].ToString(),
                    Avatar = user.ProfilePicture,
                };
                list.Add(en);
            }

            ViewBag.Title = "Quản lý người dùng";
            return View(list);
        }
    }
}
