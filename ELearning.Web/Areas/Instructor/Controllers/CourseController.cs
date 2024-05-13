using ELearning.Business.Services.Interfaces;
using ELearning.DomainModels;
using ELearning.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ELearning.Web.Areas.Instructor.Controllers
{
    [Authorize(Roles = "Instructor")]
    [Area("Instructor")]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly ITopicService _topicService;
        private readonly ILevelService _levelService;
        
        private readonly ILogger<CourseController> _logger;

        public CourseController(ICourseService courseService, ITopicService topicService, ILevelService levelService, ILogger<CourseController> logger)
        {
            _courseService = courseService;
            _topicService = topicService;
            _levelService = levelService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                List<Course> courses = await _courseService.GetAllCourseByInstructorIdAsync(2);
                List<Topic> topics = await _topicService.GetAllTopicsAsync();
                List<Level> levels = await _levelService.GetAllLevelsAsync();

                var courseVM = new CourseViewModel()
                {
                    Courses = courses,
                    Topics = topics,
                    Levels = levels
                    
                };

                return View(courseVM);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<IActionResult> CreateCourse()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }
    }
}
