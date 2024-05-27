using ELearning.Business.DTOs.CoursesDTOs.CourseDetail;
using ELearning.Business.Services.Interfaces;
using ELearning.Web.Areas.Instructor.Controllers;
using ELearning.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ELearning.Web.Areas.Student.Controllers
{

    [Area("Student")]
    [Authorize(Roles = "Student")]
    public class HomeController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly ITopicService _topicService;
        private readonly ILevelService _levelService;
        private readonly ISectionService _sectionService;
        private readonly ILessonService _lessonService;
        private readonly ICourseRequestService _courseRequestService;

        private readonly ILogger<CourseController> _logger;

        public HomeController(ICourseService courseService, ITopicService topicService, ILevelService levelService, ISectionService sectionService, ILessonService lessonService, ICourseRequestService courseRequestService, ILogger<CourseController> logger)
        {
            _courseService = courseService;
            _topicService = topicService;
            _levelService = levelService;
            _sectionService = sectionService;
            _lessonService = lessonService;
            _courseRequestService = courseRequestService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var course = await _courseService.GetAllCoursesAsync();
                var courseVM = new List<CourseDetailViewModel>();
                courseVM = course.Select(p => new CourseDetailViewModel
                {
                    CourseId = p.CourseId,
                    CourseName = p.CourseName,
                    ShortDescription = p.ShortDescription,
                    Description = p.Description,
                    TopicName = p.TopicName,
                    LevelName = p.LevelName,
                    Duration = p.Duration,
                    CourseImage = p.CourseImage,
                    Status = p.Status,
                    Price = p.Price,
                    IsFree = p.IsFree,
                    SalePrice = p.SalePrice,
                    SaleStart = p.SaleStart,
                    SaleEnd = p.SaleEnd,
                    InstructorName = p.InstructorName,
                    EnrolledStudentCount = p.EnrolledStudentCount,
                    AverageRating = p.AverageRating,
                }).ToList();

                ViewBag.Menu = "home";
                return View(courseVM);

            } catch  (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }
    }
}
