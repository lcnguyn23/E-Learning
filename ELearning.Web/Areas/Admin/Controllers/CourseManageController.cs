using ELearning.Business.DTOs.CourseDTOs.CourseRequest;
using ELearning.Business.DTOs.CoursesDTOs.CourseDetail;
using ELearning.Business.DTOs.CoursesDTOs.Lessons;
using ELearning.Business.Services.Interfaces;
using ELearning.Data;
using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels;
using ELearning.Web.AppCodes;
using ELearning.Web.Areas.Instructor.Controllers;
using ELearning.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ELearning.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class CourseManageController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly ITopicService _topicService;
        private readonly ILevelService _levelService;
        private readonly ISectionService _sectionService;
        private readonly ILessonService _lessonService;
        private readonly ICourseRequestService _courseRequestService;
        private readonly ICourseRepository _courseRepository;

        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IUserService _userService;
        private readonly ILogger<CourseController> _logger;

        private readonly ELearningDbContext _context;

       
        public CourseManageController(ICourseService courseService, ITopicService topicService, ILevelService levelService, ISectionService sectionService, ILessonService lessonService, ICourseRequestService courseRequestService, ICourseRepository courseRepository, IHttpContextAccessor httpContextAccessor, IUserService userService, ILogger<CourseController> logger, ELearningDbContext context)
        {
            _courseService = courseService;
            _topicService = topicService;
            _levelService = levelService;
            _sectionService = sectionService;
            _lessonService = lessonService;
            _courseRequestService = courseRequestService;
            _courseRepository = courseRepository;
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index(int? pageNumber, string? searchString)
        {
            IQueryable<CourseDetailDTO> courseQuery = await _courseService.GetAllCoursesAsync(searchString, null, null, null, null);

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

            ViewBag.Title = "Quản lý khóa học";
            return View(paginatedCourses);
        }

        [HttpGet]
        public async Task<IActionResult> ApproveCourse()
        {
            var courseRequest = await _courseRequestService.GetAllCourseRequestsAsync();
            if (courseRequest == null)
            {
                courseRequest = new List<CourseRequestListDTO>();
                ViewBag.Message = "Không có yêu cầu nào.";
                ViewBag.Title = "Phê duyệt khóa học";
                return View(courseRequest);
            }
            ViewBag.Title = "Phê duyệt khóa học";
            return View(courseRequest);
        }

        public async Task<IActionResult> ApproveExecute(int requestId)
        {
            var courseRe = await _courseRequestService.GetCourseRequestByIdAsync(requestId);

            var courseUpdate = new CourseRequestUpdateDTO()
            {
                CourseRequestId = requestId,
                CourseId = courseRe.CourseId,
                InstructorId = courseRe.InstructorId,
                Status = CourseRequestStatus.APPROVED,
                ResponseAt = DateTime.Now,
            };

            await _courseRequestService.UpdateCourseRequestAsync(courseUpdate);

            var data = await _courseRepository.GetByIdAsync(courseUpdate.CourseId);

            data.Status = CourseStatus.PUBLISH;

            await _courseRepository.UpdateAsync(data);

            ViewBag.SuccessMessage = "Phê duyệt thành công";
            ViewBag.Title = "Phê duyệt khóa học";
            return RedirectToAction("ApproveCourse");

        }

        public async Task<IActionResult> ChangeStatus(int courseId)
        {
            var course = await _courseRepository.GetByIdAsync(courseId);

            course.Status = CourseStatus.UNPUBLISH;

            var result = await _courseRepository.UpdateAsync(course);

            return RedirectToAction("Index", "CourseManage");
        }

        public async Task<IActionResult> CourseDetail(int courseId)
        {
            try
            {
                if (!ModelState.IsValid)
                {

                    return RedirectToAction("Index");
                }

                var model = await _courseService.GetCourseByIdAsync(courseId);
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

                ViewBag.Title = "Thông tin khóa học";
                return View("CourseDetail", courseContentVM);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }
    }
}
