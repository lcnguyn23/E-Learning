using ELearning.Business.DTOs;
using ELearning.Business.DTOs.CoursesDTOs.CourseDetail;
using ELearning.Business.DTOs.EnrollmentDTOs;
using ELearning.Business.Services.Interfaces;
using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels.EnrollmentManagement;
using ELearning.Web.AppCodes;
using ELearning.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ELearning.Web.Areas.Instructor.Controllers
{
    [Authorize(Roles = "Instructor")]
    [Area("Instructor")]
    public class StudentEnrollController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly ISectionService _sectionService;
        private readonly ILessonService _lessonService;
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IUserService _userService;
        private readonly ILogger<CourseController> _logger;

        public StudentEnrollController(ICourseService courseService, ISectionService sectionService, ILessonService lessonService, IEnrollmentRepository enrollmentRepository, IHttpContextAccessor httpContextAccessor, IUserService userService, ILogger<CourseController> logger)
        {
            _courseService = courseService;
            _sectionService = sectionService;
            _lessonService = lessonService;
            _enrollmentRepository = enrollmentRepository;
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var currentUserEmail = _httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(p => p.Type.Contains("email")).Value;
            var currentUser = await _userService.GetUserByEmailAsync(currentUserEmail);

            if (currentUser == null)
            {
                return RedirectToAction("Login", "Account");
            }

            IQueryable<CourseDetailDTO> courses = await _courseService.GetAllCourseByInstructorIdAsync(currentUser.Id, null, null, null, null, null);
            _logger.LogInformation($"slslslslsl {courses.Count()}");
            IQueryable<StudentEnrolledDTO> students = await _courseService.GetAllStudentEnrolledAsync();

            
            var courseWithStudents = courses.Select(course => new StudentEnrolledViewModel
            {
                CourseId = course.CourseId,
                CourseName = course.CourseName,
                CourseImage = course.CourseImage,
                StudentEnrolled = students.Where(student => student.CourseId == course.CourseId).ToList()
            }).ToList();


            ViewBag.Title = "Học viên của tôi";
            return View(courseWithStudents.AsQueryable());
        }

        public async Task<IActionResult> AddStudent()
        {
            var currentUserEmail = _httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(p => p.Type.Contains("email")).Value;
            var currentUser = await _userService.GetUserByEmailAsync(currentUserEmail);

            if (currentUser == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var add = new AddStudentViewModel()
            {
                InstructorId = currentUser.Id,
            };
            ViewBag.Title = "Thêm học viên";
            return View(add);
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(AddStudentViewModel model)
        {
            var currentUserEmail = _httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(p => p.Type.Contains("email")).Value;
            var currentUser = await _userService.GetUserByEmailAsync(currentUserEmail);

            var student = await _userService.GetUserByEmailAsync(model.StudentEmail);
            if (student == null)
            {
                ViewBag.ErrorMessage = "Học viên không tồn tại.";
                ViewBag.Title = "Thêm học viên";
                var add = new AddStudentViewModel()
                {
                    InstructorId = currentUser.Id,
                };
                return View(add);
            }

            var checkEnroll = await _enrollmentRepository.GetEnrollmentByCourseAndStudentAsync(student.Id, model.CourseId);
            
            if (checkEnroll != null)
            {
                ViewBag.ErrorMessage = "Học viên đã đăng ký khóa học.";
                ViewBag.Title = "Thêm học viên";
                var add = new AddStudentViewModel()
                {
                    InstructorId = currentUser.Id,
                };
                return View(add);
            }

            var enroll = new Enrollment()
            {
                CourseId = model.CourseId,
                StudentId = student.Id,
                Status = EnrollmentStatus.ENROLLED,
                CreatedAt = DateTime.Now,
            };

            var result = await _enrollmentRepository.CreateAsync(enroll);

            if (result < 0)
            {
                ViewBag.ErrorMessage = "Thêm học viên thất bại.";
                ViewBag.Title = "Thêm học viên";
                var add = new AddStudentViewModel()
                {
                    InstructorId = currentUser.Id,
                };
                return View(add);
            }

            ViewBag.Title = "Thêm học viên";
            ViewBag.SuccessMessage = "Thêm học viên thành công.";
            return View(model);
        }
    }
}
