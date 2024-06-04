using ELearning.Business.Services.Interfaces;
using ELearning.Data.Repositories.Interfaces;
using ELearning.Data;
using ELearning.Web.Areas.Instructor.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ELearning.DomainModels;
using ELearning.Web.AppCodes;
using ELearning.Web.Models;
using Microsoft.EntityFrameworkCore;
using ELearning.Business.DTOs.CoursesDTOs.Lessons;

namespace ELearning.Web.Areas.Student.Controllers
{
    [Area("Student")]
    [Authorize(Roles = "Student")]
    public class MyCourseController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly ITopicService _topicService;
        private readonly ILevelService _levelService;
        private readonly ISectionService _sectionService;
        private readonly ILessonService _lessonService;
        private readonly ICourseRequestService _courseRequestService;
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IStudentProgressRepository _studentProgressRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IUserService _userService;

        private readonly ILogger<CourseController> _logger;
        private readonly ELearningDbContext _context;
        private const int pageSize = 12;

        public MyCourseController(ICourseService courseService, ITopicService topicService, ILevelService levelService, ISectionService sectionService, ILessonService lessonService, ICourseRequestService courseRequestService, IEnrollmentRepository enrollmentRepository, IStudentProgressRepository studentProgressRepository, IHttpContextAccessor httpContextAccessor, IUserService userService, ILogger<CourseController> logger, ELearningDbContext context)
        {
            _courseService = courseService;
            _topicService = topicService;
            _levelService = levelService;
            _sectionService = sectionService;
            _lessonService = lessonService;
            _courseRequestService = courseRequestService;
            _enrollmentRepository = enrollmentRepository;
            _studentProgressRepository = studentProgressRepository;
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index(int? pageNumber)
        {
            try
            {
                var currentUserEmail = _httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(p => p.Type.Contains("email")).Value;
                var currentUser = await _userService.GetUserByEmailAsync(currentUserEmail);


                var courseQuery = _context.Courses
                .Include(p => p.Enrollments)
                .Include(p => p.Topic)  // Join với bảng topics
                .Include(p => p.Level) // Join với bảng levels
                .Include(p => p.Enrollments) // Join với bảng enrollments
                .Include(p => p.CourseRatings) // Join với bảng ratings
                .Include(p => p.Instructor)
                .Include(p => p.StudentProgresses)
                .Where(p => p.Enrollments.Any(p => p.StudentId == currentUser.Id))
                .Select(p => new CourseDetailViewModel
                {
                    CourseId = p.CourseId,
                    CourseName = p.CourseName,
                    ShortDescription = p.ShortDescription,
                    Description = p.Description,
                    TopicName = p.Topic.TopicName, // Truy cập vào thuộc tính Topic.Name sau khi đã thực hiện Include
                    LevelName = p.Level.LevelName, // Truy cập vào thuộc tính Level.Name sau khi đã thực hiện Include
                    Duration = p.Duration,
                    CourseImage = p.CourseImage,
                    Status = p.Status,
                    Price = p.Price,
                    IsFree = p.IsFree,
                    SalePrice = p.SalePrice,
                    SaleStart = p.SaleStart,
                    SaleEnd = p.SaleEnd,
                    InstructorName = p.Instructor.FullName,
                    EnrolledStudentCount = p.Enrollments.Count(), // Sử dụng Count để đếm số lượng học viên đã đăng ký
                    AverageRating = p.CourseRatings.Average(r => r.Rating), // Tính trung bình điểm đánh giá
                    Progress = p.StudentProgresses.Count(),
                });


                // Sử dụng PaginatedList để phân trang
                int pageSize = 12; // Số lượng mục trên mỗi trang
                var paginatedCourses = await PaginatedList<CourseDetailViewModel>.CreateAsync(courseQuery, pageNumber ?? 1, pageSize);

                ViewBag.Menu = "home";
                return View(paginatedCourses);

            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Search(string searchString, int topicId, int levelId, int rating, int? pageNumber)
        {
            try
            {
                var currentUserEmail = _httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(p => p.Type.Contains("email")).Value;
                var currentUser = await _userService.GetUserByEmailAsync(currentUserEmail);
                IQueryable<Course> courseQuery = _context.Courses
                                    .Where(p => p.Status == CourseStatus.PUBLISH && p.IsDeleted == false)
                                    .Include(p => p.Topic) // Join với bảng topics
                                    .Include(p => p.Level) // Join với bảng levels
                                    .Include(p => p.Enrollments) // Join với bảng enrollments
                                    .Include(p => p.CourseRatings) // Join với bảng ratings
                                    .Include(p => p.Instructor)
                                    .Where(p => p.Enrollments.Any(p => p.StudentId == currentUser.Id));

                // 
                if (!string.IsNullOrEmpty(searchString))
                {
                    courseQuery = courseQuery.Where(p => p.CourseName.Contains(searchString) || p.Instructor.FullName.Contains(searchString));
                }


                // Lọc theo chủ đề
                if (topicId != 0)
                {
                    courseQuery = courseQuery.Where(p => p.TopicId == topicId);
                }

                // Lọc theo cấp độ
                if (levelId != 0)
                {
                    courseQuery = courseQuery.Where(p => p.LevelId == levelId);
                }

                // Lọc theo số sao tối thiểu trong đánh giá
                if (rating != 0)
                {
                    courseQuery = courseQuery.Where(p => p.CourseRatings.Average(r => r.Rating) >= rating);
                }
                // Chọn các trường để hiển thị trong ViewModel
                var courseViewModels = courseQuery
                    .Select(p => new CourseDetailViewModel
                    {
                        CourseId = p.CourseId,
                        CourseName = p.CourseName,
                        ShortDescription = p.ShortDescription,
                        Description = p.Description,
                        TopicName = p.Topic.TopicName,
                        LevelName = p.Level.LevelName,
                        Duration = p.Duration,
                        CourseImage = p.CourseImage,
                        Status = p.Status,
                        Price = p.Price,
                        IsFree = p.IsFree,
                        SalePrice = p.SalePrice,
                        SaleStart = p.SaleStart,
                        SaleEnd = p.SaleEnd,
                        InstructorName = p.Instructor.FullName,
                        EnrolledStudentCount = p.Enrollments.Count(),
                        AverageRating = p.CourseRatings.Average(r => r.Rating)
                    });

                // Sử dụng PaginatedList để phân trang
                int pageSize = 12; // Số lượng mục trên mỗi trang
                var paginatedCourses = await PaginatedList<CourseDetailViewModel>.CreateAsync(courseViewModels, pageNumber ?? 1, pageSize);

                ViewBag.Menu = "home";
                ViewBag.SearchString = searchString;
                return RedirectToAction("Index", "MyCourse", paginatedCourses);
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

                ViewBag.Title = "Thông tin khóa học";
                return View("CourseDetail", courseContentVM);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<IActionResult> Study(int id, int lessonId)
        {
            try
            {
                var currentUserEmail = _httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(p => p.Type.Contains("email")).Value;
                var currentUser = await _userService.GetUserByEmailAsync(currentUserEmail);
                var model = await _courseService.GetCourseByIdAsync(id);
                if (model == null)
                {
                    ViewBag.ErrorMessage = "Khóa học không tồn tại";
                    return RedirectToAction("Index", "Home");
                }

                var sections = await _sectionService.GetAllSectionsAsync(model.CourseId);
                var lessonIn = await _lessonService.GetLessonByIdAsync(lessonId);
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

                var content = await _lessonService.GetLessonContentByIdAsync(lessonId);
                var media = await _lessonService.GetLessonMediaByIdAsync(lessonId);
                var progress = await _studentProgressRepository.GetProgressAsync(currentUser.Id, id);
                bool isFinished = false;
                foreach(var pro in progress)
                {
                    if (lessonIn.LessonId == pro.LessonId) { isFinished = true; break; }
                }
                var detail = new LessonPageViewModel()
                {
                    LessonId = lessonId,
                    Title = lessonIn.Title,
                    Order = lessonIn.Order,
                    LessonContent = content,
                    LessonMedia = media,
                    SectionId = lessonIn.SectionId,
                    CourseId = id,
                    CourseContent = courseContentVM,
                    IsFinished = isFinished,
                };
                ViewBag.Title = "Thông tin khóa học";
                return View(detail);

            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<IActionResult> SaveProgress(int id, int sectionId, int lessonId)
        {
            var currentUserEmail = _httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(p => p.Type.Contains("email")).Value;
            var currentUser = await _userService.GetUserByEmailAsync(currentUserEmail);

            var sections = await _sectionService.GetSectionByIdAsync(sectionId);
            var lesson = await _lessonService.GetLessonByIdAsync(lessonId);
            var nextSections = await _sectionService.GetNextSectionAsync(id, sectionId);

            if (lesson.Order == sections.LessonCount)
            {
                var lessonNew = await _lessonService.GetAllLessonsBySectionIdAsync(nextSections.SectionId);
                var nextLesson = await _lessonService.GetNextLesson(nextSections.SectionId, lessonNew[0].LessonId);
                var data = new StudentProgress()
                {
                    StudentId = currentUser.Id,
                    CourseId = id,
                    SectionId = sectionId,
                    LessonId = lessonId,
                };
                var save = await _studentProgressRepository.CreateAsync(data);
                return RedirectToAction("Study", new { id = id, lessonId = lessonNew[0].LessonId }); 
            }
            else
            {
                var nextLesson = await _lessonService.GetNextLesson(sectionId, lessonId);
                var data = new StudentProgress()
                {
                    StudentId = currentUser.Id,
                    CourseId = id,
                    SectionId = sectionId,
                    LessonId = lessonId,
                };
                var save = await _studentProgressRepository.CreateAsync(data);
                return RedirectToAction("Study", new { id = id, lessonId = nextLesson.LessonId });
            }

            
        }

        public async Task<IActionResult> EnrollHistory()
        {
            var currentUserEmail = _httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(p => p.Type.Contains("email")).Value;
            var currentUser = await _userService.GetUserByEmailAsync(currentUserEmail);

            var courses = await _courseService.GetAllCoursesAsync(null, null, null, null, null);
            var instructor = await _userService.GetInstructorAsync();
            _logger.LogInformation($"cur {currentUser.Id}");
            var enrolled = await _enrollmentRepository.GetEnrollmentsByStudentIdAsync(currentUser.Id);


            _logger.LogInformation($"cur2 {enrolled.Count()}");
            var list = new List<EnrollCourseListViewModel>();
            foreach (var item in enrolled)
            {
                var courseIn = await _courseService.GetCourseByIdAsync(item.CourseId);
                var enroll = new EnrollCourseListViewModel()
                {
                    EnrollmentId = item.EnrollmentId,
                    EnrollAt = item.CreatedAt,
                    StudentId = item.StudentId,
                    CourseId = item.CourseId,
                    EnrollmentStatus = item.Status,
                    CourseName = courseIn.CourseName,
                    InstructorName = courseIn.InstructorName
                };
                list.Add(enroll);
            }

            ViewBag.Title = "Lịch sử đăng ký";
            return View(list);
        }
    }
}
