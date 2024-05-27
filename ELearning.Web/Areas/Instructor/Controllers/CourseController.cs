using ELearning.Business.DTOs.CourseDTOs.CourseRequest;
using ELearning.Business.DTOs.CoursesDTOs.CourseDetail;
using ELearning.Business.DTOs.CoursesDTOs.LessonContentMedia;
using ELearning.Business.DTOs.CoursesDTOs.Lessons;
using ELearning.Business.DTOs.CoursesDTOs.Sections;
using ELearning.Business.Services.Implementation;
using ELearning.Business.Services.Implementations;
using ELearning.Business.Services.Interfaces;
using ELearning.Business.Utility;
using ELearning.Data;
using ELearning.DomainModels;
using ELearning.Web.AppCodes;
using ELearning.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ELearning.Web.Areas.Instructor.Controllers
{
    [Authorize(Roles = "Instructor")]
    [Area("Instructor")]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly ITopicService _topicService;
        private readonly ILevelService _levelService;
        private readonly ISectionService _sectionService;
        private readonly ILessonService _lessonService;
        private readonly ICourseRequestService _courseRequestService;

        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IUserService _userService;
        private readonly ILogger<CourseController> _logger;

        private readonly ELearningDbContext _context;



        public CourseController(ICourseService courseService, ITopicService topicService, ILevelService levelService, ISectionService sectionService, ILessonService lessonService, ICourseRequestService courseRequestService, IHttpContextAccessor httpContextAccessor, IUserService userService, ILogger<CourseController> logger, ELearningDbContext context)
        {
            _courseService = courseService;
            _topicService = topicService;
            _levelService = levelService;
            _sectionService = sectionService;
            _lessonService = lessonService;
            _courseRequestService = courseRequestService;
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

                if (currentUser == null)
                {
                    return RedirectToAction("Login", "Account");
                }

                IQueryable<Course> courseQuery = _context.Courses
                                    .Where(p => p.IsDeleted == false)
                                    .Include(p => p.Topic) // Join với bảng topics
                                    .Include(p => p.Level) // Join với bảng levels
                                    .Include(p => p.Enrollments) // Join với bảng enrollments
                                    .Include(p => p.CourseRatings) // Join với bảng ratings
                                    .Include(p => p.Instructor);

                courseQuery = courseQuery.Where(p => p.InstructorId == currentUser.Id);

                var courseViewModels = courseQuery
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
                    AverageRating = p.CourseRatings.Average(r => r.Rating) // Tính trung bình điểm đánh giá
                });

                // Sử dụng PaginatedList để phân trang
                int pageSize = 12; // Số lượng mục trên mỗi trang
                var paginatedCourses = await PaginatedList<CourseDetailViewModel>.CreateAsync(courseViewModels, pageNumber ?? 1, pageSize);

                ViewBag.Menu = "home";
                return View(paginatedCourses);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<IActionResult> Search(string searchString, int topicId, int levelId, CourseStatus status, int? pageNumber)
        {
            try
            {
                var currentUserEmail = _httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(p => p.Type.Contains("email")).Value;
                var currentUser = await _userService.GetUserByEmailAsync(currentUserEmail);

                if (currentUser == null)
                {
                    return RedirectToAction("Login", "Account");
                }

                IQueryable<Course> courseQuery = _context.Courses
                                    .Where(p => p.IsDeleted == false)
                                    .Include(p => p.Topic) // Join với bảng topics
                                    .Include(p => p.Level) // Join với bảng levels
                                    .Include(p => p.Enrollments) // Join với bảng enrollments
                                    .Include(p => p.CourseRatings) // Join với bảng ratings
                                    .Include(p => p.Instructor);

                courseQuery = courseQuery.Where(p => p.InstructorId == currentUser.Id);
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

                if (status != 0)
                {
                    
                    courseQuery = courseQuery.Where(p => p.Status == status);
                }

                var courseViewModels = courseQuery
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
                    AverageRating = p.CourseRatings.Average(r => r.Rating) // Tính trung bình điểm đánh giá
                });

                // Sử dụng PaginatedList để phân trang
                int pageSize = 12; // Số lượng mục trên mỗi trang
                var paginatedCourses = await PaginatedList<CourseDetailViewModel>.CreateAsync(courseViewModels, pageNumber ?? 1, pageSize);

                ViewBag.Menu = "home";
                return View(paginatedCourses);
            } catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }

        }

        public async Task<IActionResult> CreateCourse()
        {
            try
            {
                var model = new CourseCreateViewModel()
                {
                    CourseId = 0
                };

                ViewBag.Menu = "addcourse";
                ViewBag.Title = "Tạo khóa học mới";
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<IActionResult> UpdateCourse(int id)
        {
            try
            {
                var model = await _courseService.GetCourseByIdAsync(id);
                if (model == null)
                    return RedirectToAction("Index");
                var normalizedTopicName = model.TopicName.Trim();
                var topic = await _topicService.GetTopicByNameAsync(normalizedTopicName);
                var level = await _levelService.GetLevelByNameAsync(model.LevelName);

                _logger.LogError($"Topic and Level id: {model.TopicName} -- {normalizedTopicName}");
                _logger.LogError($"Topic and Level id: {topic.TopicId} -- {level.LevelId}");

                var data = new CourseCreateViewModel()
                {
                    CourseId = model.CourseId,
                    CourseName = model.CourseName,
                    ShortDescription = model.ShortDescription,
                    Description = model.Description,
                    TopicId = topic.TopicId,
                    LevelId = level.LevelId,
                    Duration = model.Duration,
                    CourseImage = model.CourseImage,
                    Status = CourseStatus.PENDING_APPROVAL,
                    Price = model.Price,
                    IsFree = model.IsFree,
                    SalePrice = model.SalePrice,
                    SaleStart = model.SaleStart,
                    SaleEnd = model.SaleEnd,
                };

                ViewBag.Title = "Cập nhật khóa học";
                ViewBag.Menu = "course";
                return View("CreateCourse", data);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveCourse(CourseCreateViewModel model, IFormFile? uploadPhoto)
        {
            try
            {
                ViewBag.Title = model.CourseId == 0 ? "Tạo khóa học mới" : "Cập nhật khóa học";


                if (uploadPhoto != null)
                {
                    long fileSize = uploadPhoto.Length;
                    long maxSize = 2000 * 1024;
                    if (fileSize > maxSize)
                    {
                        ModelState.AddModelError(nameof(model.CourseImage), "Kích thước ảnh quá lơn.");
                    }
                    else
                    {
                        string fileName = $"{DateTime.Now.Ticks}_{uploadPhoto.FileName}";
                        string filePath = System.IO.Path.Combine(ApplicationContext.HostEnviroment.WebRootPath, @"media\course", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            uploadPhoto.CopyTo(stream);
                        }
                        model.CourseImage = fileName;
                    }
                }

                _logger.LogInformation($"img = {model.CourseImage}");

                if (!ModelState.IsValid)
                {

                    ViewBag.ErrorMessage = "Không thể tạo khóa học";
                    _logger.LogInformation($"error?");
                    return View("CreateCourse", model);
                }


                if (model.CourseId == 0)
                {
                    var newCourse = new CourseCreateDTO()
                    {
                        CourseName = model.CourseName,
                        ShortDescription = model.ShortDescription,
                        Description = model.Description ?? string.Empty,
                        TopicId = model.TopicId,
                        LevelId = model.LevelId,
                        Duration = model.Duration,
                        CourseImage = model.CourseImage,
                        Status = CourseStatus.UNPUBLISH,
                        Price = model.Price,
                        IsFree = model.IsFree == null ? false : model.IsFree,
                        SalePrice = model.SalePrice ?? null,
                        SaleStart = model.SaleStart ?? null,
                        SaleEnd = model.SaleEnd ?? null,

                    };

                    var result = await _courseService.CreateCourseAsync(newCourse);
                    _logger.LogInformation($"result: {result}");
                    if (result > 0)
                    {
                        var course = await _courseService.GetCourseByNameAsync(model.CourseName);
                        ViewBag.Menu = "course";
                        return RedirectToAction("CourseDetail", new { id = course.CourseId });
                    }

                    ViewBag.ErrorMessage = "Không thể tạo khóa học";
                    return View("CreateCourse", model);
                }
                else
                {
                    var newCourse = new CourseUpdateDTO()
                    {
                        CourseId = model.CourseId,
                        CourseName = model.CourseName,
                        ShortDescription = model.ShortDescription,
                        Description = model.Description ?? string.Empty,
                        TopicId = model.TopicId,
                        LevelId = model.LevelId,
                        Duration = model.Duration,
                        CourseImage = model.CourseImage,
                        Status = model.Status,
                        Price = (decimal)model.Price,
                        IsFree = (bool)(model.IsFree == null ? false : model.IsFree),
                        SalePrice = model.SalePrice,
                        SaleStart = model.SaleStart,
                        SaleEnd = model.SaleEnd,

                    };

                    var result = await _courseService.UpdateCourseAsync(newCourse);
                    if (result > 0)
                    {
                        return RedirectToAction("Index");
                    }
                    ViewBag.ErrorMessage = "Không thể cập nhật thông tin khóa học";
                    return View("UpdateCourse", model);
                }
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

        public async Task<IActionResult> DeleteCourse(int id)
        {
            try
            {
                var model = await _courseService.GetCourseByIdAsync(id);
                var result = await _courseService.DeleteCourseAsync(model);

                var changeStatus = new CourseUpdateDTO()
                {
                    CourseId = id,
                    Status = CourseStatus.UNPUBLISH,
                };

                var status = await _courseService.UpdateCourseAsync(changeStatus);
                if (result > 0)
                {
                    ViewBag.Message = "Xóa khóa học thành công";
                    return RedirectToAction("Index", "Course");
                }
                ViewBag.ErrorMessage = "Không thể xóa khóa học";
                return RedirectToAction("CourseDetail", model);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        [HttpGet]
        public async Task<PartialViewResult> CreateSection(int courseId)
        {
            try
            {
                var sectionVM = new SectionCreateViewModel()
                {
                    CourseId = courseId,
                };
                ViewBag.ModalTitle = "Tạo chương mới";
                return PartialView("CreateSection", sectionVM);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateSection(SectionCreateViewModel model)
        {
            try
            {
                var courseSection = await _sectionService.GetAllSectionsAsync(model.CourseId);

                var maxOrder = courseSection.Count();
                _logger.LogInformation($"Max order: {maxOrder}");
                //TODO: fix order 
                if (maxOrder == null)
                {
                    maxOrder = 0;
                }
                var sectionCreateDTO = new SectionCreateDTO()
                {
                    CourseId = model.CourseId,
                    Title = model.Title,
                    Order = maxOrder + 1
                };



                var result = await _sectionService.CreateSectionAsync(sectionCreateDTO);
                if (result > 0)
                {
                    return RedirectToAction("CourseDetail", new { id = sectionCreateDTO.CourseId });
                }

                ViewBag.ErrorMessage = "Không thể tạo chương mới";
                return PartialView("CreateSection", model);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        [HttpGet]
        public async Task<PartialViewResult> UpdateSection(int sectionId)
        {
            try
            {

                _logger.LogInformation($"int sectionid: {sectionId}");
                var section = await _sectionService.GetSectionByIdAsync(sectionId);
                _logger.LogInformation($"int sectionorder: {section.SectionOrder}");
                var sectionVM = new SectionCreateViewModel()
                {
                    CourseId = section.CourseId,
                    SectionId = section.SectionId,
                    Title = section.Title,
                    SectionOrder = section.SectionOrder
                };
                ViewBag.ModalTitle = "Cập nhật chương";
                return PartialView("UpdateSection", sectionVM);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSection(SectionCreateViewModel model)
        {
            try
            {
                var sectionCreateDTO = new SectionUpdateDTO()
                {
                    SectionId = model.SectionId,
                    CourseId = model.CourseId,
                    Title = model.Title,
                    Order = model.SectionOrder
                };

                var result = await _sectionService.UpdateSectionAsync(sectionCreateDTO);
                if (result > 0)
                {
                    return RedirectToAction("CourseDetail", new { id = sectionCreateDTO.CourseId });
                }

                ViewBag.ErrorMessage = "Không thể cập nhật chương.";
                return PartialView("UpdateSection", model);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<IActionResult> DeleteSection(int id)
        {
            try
            {
                var model = await _sectionService.GetSectionByIdAsync(id);
                var result = await _sectionService.DeleteSectionAsync(model);

                if (result > 0)
                {
                    ViewBag.Message = "Xóa chương thành công";
                    return RedirectToAction("Index", "Course");
                }
                ViewBag.ErrorMessage = "Không thể xóa chương";
                return RedirectToAction("CourseDetail", new {id = model.CourseId});

            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> LessonDetail(int id)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return RedirectToAction("Index", "Course");
                }
                _logger.LogInformation($"iidididid: {id}");
                var lesson = await _lessonService.GetLessonByIdAsync(id);
                var course = await _lessonService.GetCourseIdAsync(id);
                var lessonContent = await _lessonService.GetLessonContentByIdAsync(id);
                var lessonMedia = await _lessonService.GetLessonMediaByIdAsync(id);
                var lessonDetailVM = new LessonDetailViewModel()
                {
                    LessonId = id,
                    CourseId = course,
                    SectionId = lesson.SectionId,
                    Title = lesson.Title,
                    Order = lesson.Order,
                    LessonContent = lessonContent == null ? new LessonContentDetailDTO() : lessonContent,
                    LessonMedia = lessonMedia == null ? new LessonMediaDetailDTO() : lessonMedia,
                };
                ViewBag.Title = "Thông tin bài giảng";
                return View(lessonDetailVM);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> CreateLesson(int sectionId)
        {
            try
            {
                var model = new LessonCreateViewModel()
                {
                    LessonId = 0,
                    SectionId = sectionId,
                    LessonContent = new LessonContentDetailDTO(),
                    LessonMedia = new LessonMediaDetailDTO(),
                };

                ViewBag.Title = "Tạo bài giảng";
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> UpdateLesson(int id)
        {
            try
            {
                var model = await _lessonService.GetLessonByIdAsync(id);
                int courseId = await _lessonService.GetCourseIdAsync(id);
                if (model == null)
                    return RedirectToAction("CourseDetail", new { id = courseId });

                var lessonContentModel = await _lessonService.GetLessonContentByIdAsync(id);
                var lessonContent = new LessonContentDetailDTO()
                {
                    LessonContentId = lessonContentModel.LessonContentId,
                    LessonId = id,
                    Content = lessonContentModel.Content,
                    Description = lessonContentModel.Description,
                };

                var lessonMediaModel = await _lessonService.GetLessonMediaByIdAsync(id);
                var lessonMedia = new LessonMediaDetailDTO()
                {
                    LessonMediaId = lessonMediaModel.LessonMediaId,
                    LessonId = id,
                    MediaName = lessonMediaModel.MediaName,
                    MediaPath = lessonMediaModel.MediaPath,
                    MediaUrl = lessonMediaModel.MediaUrl,
                    MediaType = lessonMediaModel.MediaType,
                    MediaContent = lessonMediaModel.MediaContent,
                };

                var data = new LessonCreateViewModel()
                {
                    LessonId = model.LessonId,
                    SectionId = model.SectionId,
                    CourseId = courseId,
                    Title = model.Title,
                    Order = model.Order,
                    LessonContent = lessonContent,
                    LessonMedia = lessonMedia
                };

                ViewBag.Title = "Cập nhật bài giảng";
                ViewBag.Menu = "course";
                return View("CreateLesson", data);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveLesson(LessonCreateViewModel model, IFormFile? uploadFile)
        {
            try
            {
                ViewBag.Title = model.CourseId == 0 ? "Tạo bài giảng" : "Cập nhật bài giảng";


                if (uploadFile != null)
                {
                    long fileSize = uploadFile.Length;
                    string fileName = $"{DateTime.Now.Ticks}_{uploadFile.FileName}";
                    string filePath = System.IO.Path.Combine(ApplicationContext.HostEnviroment.WebRootPath, @"media\lessonmedia", fileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        uploadFile.CopyTo(stream);
                    }
                    model.LessonMedia.MediaName = fileName;
                    model.LessonMedia.MediaPath = fileName;
                    model.LessonMedia.FizeSize = fileSize;
                }


                if (!ModelState.IsValid)
                {

                    ViewBag.ErrorMessage = "Không thể tạo bài giảng";
                    return View("CreateLesson", model);
                }


                if (model.LessonId == 0)
                {
                    var allessons = await _lessonService.GetAllLessonsBySectionIdAsync(model.SectionId);

                    var maxOrder = allessons.Count();

                    var newLesson = new LessonCreateDTO()
                    {
                        CourseId = model.CourseId,
                        SectionId = model.SectionId,
                        Title = model.Title,
                        Order = maxOrder + 1,
                        LessonContentId = model.LessonContent.LessonContentId,
                        LessonMediaId = model.LessonMedia.LessonMediaId
                    };
                    var result = await _lessonService.CreateLessonAsync(newLesson);

                    var lessonId = await _lessonService.GetLessonIdByTitleAsync(model.Title);
                    var newLessonContent = new LessonContentCreateDTO()
                    {
                        LessonId = lessonId,
                        Description = model.LessonContent.Description,
                        Content = model.LessonContent.Content,
                    };
                    var createContent = await _lessonService.CreateLessonContentAsync(newLessonContent);

                    var newLesssonMedia = new LessonMediaCreateDTO()
                    {
                        LessonId = lessonId,
                        MediaName = model.LessonMedia.MediaName,
                        MediaContent = model.LessonMedia.MediaContent,
                        MediaPath = model.LessonMedia.MediaPath,
                        MediaType = model.LessonMedia.MediaType,
                        MediaUrl = model.LessonMedia.MediaUrl,
                    };
                    var createMedia = await _lessonService.CreateLessonMediaAsync(newLesssonMedia);

                    if (result > 0)
                    {
                        ViewBag.Menu = "course";
                        return RedirectToAction("LessonDetail", new { id = lessonId });
                    }

                    ViewBag.ErrorMessage = "Không thể tạo bài giảng";
                    return View("CreateLesson", model);
                }
                else
                {
                    var newLesson = new LessonUpdateDTO()
                    {
                        LessonId = model.LessonId,
                        CourseId = model.CourseId,
                        SectionId = model.SectionId,
                        Title = model.Title,
                        Order = model.Order,
                        LessonContentId = model.LessonContent.LessonContentId,
                        LessonMediaId = model.LessonMedia.LessonMediaId
                    };
                    var result = await _lessonService.UpdateLessonAsync(newLesson);

                    var newLessonContent = new LessonContentUpdateDTO()
                    {
                        LessonContentId = model.LessonContent.LessonContentId,
                        LessonId = model.LessonId,
                        Description = model.LessonContent.Description,
                        Content = model.LessonContent.Content,
                    };
                    var createContent = await _lessonService.UpdateLessonContentAsync(newLessonContent);

                    var newLesssonMedia = new LessonMediaUpdateDTO()
                    {
                        LessonMediaId = model.LessonMedia.LessonMediaId,
                        LessonId = model.LessonId,
                        MediaName = model.LessonMedia.MediaName,
                        MediaContent = model.LessonMedia.MediaContent,
                        MediaPath = model.LessonMedia.MediaPath,
                        MediaType = model.LessonMedia.MediaType,
                        MediaUrl = model.LessonMedia.MediaUrl,
                    };
                    var createMedia = await _lessonService.UpdateLessonMediaAsync(newLesssonMedia);
                    if (result > 0)
                    {
                        ViewBag.Menu = "course";
                        return RedirectToAction("LessonDetail", new { id = model.CourseId });
                    }
                    ViewBag.ErrorMessage = "Không thể cập nhật bài giảng";
                    return View("UpdateLesson", model);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<IActionResult> SendCourseRequest(int id)
        {
            try
            {
                _logger.LogInformation($" course id   ====== {id}");
                // Check if the course exists
                var course = await _courseService.GetCourseByIdAsync(id);
                if (course == null)
                {
                    ViewBag.ErrorMessage = "Khóa học không tồn tại.";
                    return RedirectToAction("CourseDetail", new { id = course.CourseId });
                }

                var requestCreateDTO = new CourseRequestCreateDTO()
                {
                    CourseId = course.CourseId,
                    Status = CourseRequestStatus.PENDING,
                    RequestAt = DateTime.Now,
                };
                var topic = await _topicService.GetTopicByNameAsync(course.TopicName);
                var level = await _levelService.GetLevelByNameAsync(course.LevelName);

                var request = await _courseRequestService.CreateCourseRequestAsync(requestCreateDTO);
                if (request > 0)
                {
                    ViewBag.SuccessMessage = "Tạo yêu cầu thành công.";
                    var newCourse = new CourseUpdateDTO()
                    {
                        CourseId = course.CourseId,
                        CourseName = course.CourseName,
                        ShortDescription = course.ShortDescription,
                        Description = course.Description ?? string.Empty,
                        TopicId = topic.TopicId,
                        LevelId = level.LevelId,
                        Duration = course.Duration,
                        CourseImage = course.CourseImage,
                        Status = CourseStatus.PENDING_APPROVAL,
                        Price = (decimal)course.Price,
                        IsFree = (bool)(course.IsFree == null ? false : course.IsFree),
                        SalePrice = course.SalePrice,
                        SaleStart = course.SaleStart,
                        SaleEnd = course.SaleEnd,
                    };

                    var result = await _courseService.UpdateCourseAsync(newCourse);
                    return RedirectToAction("CourseDetail", new { id = course.CourseId }); ;
                }

                ViewBag.ErrorMessage = "Tạo yêu cầu thất bại.";
                return RedirectToAction("CourseDetail", new { id = course.CourseId });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                ViewBag.ErrorMessage = "Tạo yêu cầu thất bại.";
                return RedirectToAction("CourseDetail", new { id = id });
            }
        }

    }
}
