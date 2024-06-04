using ELearning.Business.DTOs.CoursesDTOs.CourseDetail;
using ELearning.Business.DTOs.CoursesDTOs.Lessons;
using ELearning.Business.Services.Implementation;
using ELearning.Business.Services.Interfaces;
using ELearning.Business.Utility;
using ELearning.Data;
using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels;
using ELearning.DomainModels.EnrollmentManagement;
using ELearning.DomainModels.User;
using ELearning.Web.AppCodes;
using ELearning.Web.Areas.Instructor.Controllers;
using ELearning.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ELearning.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly ITopicService _topicService;
        private readonly ILevelService _levelService;
        private readonly ISectionService _sectionService;
        private readonly ILessonService _lessonService;
        private readonly ICourseRequestService _courseRequestService;
        private readonly IEnrollmentRepository _enrollmentRepository;

        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IUserService _userService;

        private readonly ILogger<CourseController> _logger;
        private readonly ELearningDbContext _context;
        private const int pageSize = 12;

        
        public HomeController(ICourseService courseService, ITopicService topicService, ILevelService levelService, ISectionService sectionService, ILessonService lessonService, ICourseRequestService courseRequestService, IEnrollmentRepository enrollmentRepository, IHttpContextAccessor httpContextAccessor, IUserService userService, ILogger<CourseController> logger, ELearningDbContext context)
        {
            _courseService = courseService;
            _topicService = topicService;
            _levelService = levelService;
            _sectionService = sectionService;
            _lessonService = lessonService;
            _courseRequestService = courseRequestService;
            _enrollmentRepository = enrollmentRepository;
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index(int? pageNumber)
        {
            try
            {
                
                IQueryable<CourseDetailDTO> courseQuery = await _courseService.GetAllCoursesAsync(null, null, null, CourseStatus.PUBLISH, null);
                

                

                var courseViewModels = courseQuery
                .Select(p => new CourseDetailViewModel
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
                    CreatedAt = p.CreatedAt,
                });

                // Sử dụng PaginatedList để phân trang
                int pageSize = 12; // Số lượng mục trên mỗi trang
                var paginatedCourses = await PaginatedList<CourseDetailViewModel>.CreateAsync(courseViewModels.AsQueryable(), pageNumber ?? 1, pageSize);

                ViewBag.Menu = "home";
                return View(paginatedCourses);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<IActionResult> CourseDetail(int id)
        {
            try
            {
                if (!ModelState.IsValid)
                {

                    return RedirectToAction("Index");
                }

                var model = await _courseService.GetCourseByIdAsync(id);
                if (model == null)
                {
                    ViewBag.ErrorMessage = "Khóa học không tồn tại";
                    return RedirectToAction("Index", "Home");
                }

                var sections = await _sectionService.GetAllSectionsAsync(model.CourseId);
                var lessons = new List<LessonDetailDTO>();
                foreach (var section in sections)
                {
                    _logger.LogInformation($"section: {section.SectionId}");
                    var lesson = await _lessonService.GetAllLessonsBySectionIdAsync(section.SectionId);
                    section.Lessons = lesson;

                }
                var courseContentVM = new CourseContentViewModel()
                {
                    CourseDetail = model,
                    SectionDetails = sections
                };

                var sectionData = new SectionCreateViewModel()
                {
                    CourseId = id,
                };
                ViewData["sectionData"] = sectionData;
                ViewBag.Title = "Thông tin khóa học";
                return View("CourseDetail", courseContentVM);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Search(string searchString, int topicId, int levelId, int rating, CourseStatus? status, int? pageNumber)
        {
            try
            {
                IQueryable<CourseDetailDTO> courseQuery = await _courseService.GetAllCoursesAsync(searchString, topicId, levelId, CourseStatus.PUBLISH, rating);
                var courseViewModels = courseQuery
                .Select(p => new CourseDetailViewModel
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
                    CreatedAt = p.CreatedAt,
                });

                // Sử dụng PaginatedList để phân trang
                int pageSize = 12; // Số lượng mục trên mỗi trang
                var paginatedCourses = await PaginatedList<CourseDetailViewModel>.CreateAsync(courseViewModels, pageNumber ?? 1, pageSize);

                ViewBag.Menu = "home";
                ViewBag.SearchString = searchString;
                return View(paginatedCourses);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<IActionResult> EnrollCourse(int id)
        {
            try
            {
                var currentUserEmail = _httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(p => p.Type.Contains("email")).Value;
                var currentUser = await _userService.GetUserByEmailAsync(currentUserEmail);

                if (currentUser == null)
                {
                    return RedirectToAction("Login", "Account");
                }

                var checkEnroll = await _enrollmentRepository.GetEnrollmentByStudentIdAsync(currentUser.Id);

                if (checkEnroll.CourseId == id)
                {
                    ViewBag.ErrorMessage = "Bạn đã đăng ký khóa học này.";
                    return RedirectToAction("CourseDetail", "Home" , new {id = id});
                }

                _logger.LogInformation($"idididid = {id}");
                var course = await _courseService.GetCourseByIdAsync(id);
                if (course == null)
                {
                    ViewBag.ErrorMessage = "Khóa học không tồn tại";
                    return View("Index", "Home");
                }
                if (course.IsFree)
                {
                    var enroll = new Enrollment()
                    {
                        StudentId = currentUser.Id,
                        CourseId = id,
                        StartDate = DateTime.Now,
                        Status = EnrollmentStatus.ENROLLED,
                        CreatedAt = DateTime.Now,
                    };
                    var result = await _enrollmentRepository.CreateAsync(enroll);
                    if (result < 0)
                    {
                        ViewBag.ErrorMessage = "Đăng ký khóa học thất bại";
                        return RedirectToAction("CourseDetail", "Home", new { id = id });

                    }
                    return RedirectToAction("Study", "MyCourse", new { id = id });
                } else
                {
                    return RedirectToAction("Payment", "Order", new {id = id});
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}