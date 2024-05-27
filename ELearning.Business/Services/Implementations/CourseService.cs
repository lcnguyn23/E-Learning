using ELearning.Business.DTOs.CourseDTOs.CourseRequest;
using ELearning.Business.DTOs.CoursesDTOs.CourseDetail;
using ELearning.Business.Services.Implementation;
using ELearning.Business.Services.Interfaces;
using ELearning.Business.Utility;
using ELearning.Data.Repositories;
using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels;
using ELearning.DomainModels.EnrollmentManagement;
using ELearning.DomainModels.User;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Section = ELearning.DomainModels.Section;

namespace ELearning.Business.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly ILogger<CourseService> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly ICourseRepository _courseRepository;
        private readonly IUserService _userService;
        private readonly ITopicRepository _topicRepository;
        private readonly ILevelRepository _levelRepository;
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly ICourseRatingRepository _courseRatingRepository;
        private readonly ICourseRequestService _courseRequestService;

        public CourseService(ILogger<CourseService> logger, IHttpContextAccessor httpContextAccessor, ICourseRepository courseRepository, IUserService userService, ITopicRepository topicRepository, ILevelRepository levelRepository, IEnrollmentRepository enrollmentRepository, ICourseRatingRepository courseRatingRepository, ICourseRequestService courseRequestService)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _courseRepository = courseRepository;
            _userService = userService;
            _topicRepository = topicRepository;
            _levelRepository = levelRepository;
            _enrollmentRepository = enrollmentRepository;
            _courseRatingRepository = courseRatingRepository;
            _courseRequestService = courseRequestService;
        }




        #region Get courses
        /// <summary>
        /// Get all record
        /// </summary>
        /// <returns></returns>
        public async Task<List<CourseDetailDTO>> GetAllCoursesAsync()
        {
            try
            {
                // get all existing course
                var courses = await _courseRepository.GetAllAsync();

                if (courses == null)
                {
                    throw new Exception("Không có khóa học nào");
                }

                // get all topic
                var topics = await _topicRepository.GetAllAsync();
                // get all level
                var levels = await _levelRepository.GetAllAsync();
                // get all enrollment

                var instrutors = await _userService.GetInstructorAsync();
                var enrollCourse = await _enrollmentRepository.GetAllAsync();
                var ratings = await _courseRatingRepository.GetAllAsync();
                var enrollDictionary = new Dictionary<int, int>();
                var ratingDictionary = new Dictionary<int, double>();
                var instructorDictionary = new Dictionary<int, string>();
                if (enrollCourse == null || ratings == null || instrutors == null)
                {
                    enrollCourse = new List<Enrollment>();
                    ratings = new List<CourseRating>();
                    instrutors = new List<ApplicationUser>();
                }
                else
                {
                    
                    foreach (var enroll in enrollCourse)
                    {
                        var enrollCount = await _enrollmentRepository.GetEnrollmentStudentCountAsync(enroll.CourseId);
                        enrollDictionary.TryAdd(enroll.CourseId, enrollCount);
                    }

                    foreach (var rating in ratings)
                    {
                        var avgRating = await _courseRatingRepository.GetAverageRating(rating.CourseId);
                        ratingDictionary.TryAdd(rating.CourseId, avgRating);
                    }

                    foreach (var ins in instrutors)
                    {
                        instructorDictionary.TryAdd(ins.Id, ins.FullName);
                    }
                }

                


                // map to DTO
                var coursesDTO = new List<CourseDetailDTO>();
                coursesDTO = courses.Select(p => new CourseDetailDTO
                {
                    CourseId = p.CourseId,
                    CourseName = p.CourseName,
                    ShortDescription = p.ShortDescription,
                    Description = p.Description,
                    TopicName = topics.FirstOrDefault(t => t.TopicId == p.TopicId).TopicName,
                    LevelName = levels.FirstOrDefault(l => l.LevelId == p.LevelId).LevelName,
                    Duration = p.Duration,
                    CourseImage = p.CourseImage,
                    Status = p.Status,
                    Price = p.Price,
                    IsFree = p.IsFree,
                    SalePrice = p.SalePrice,
                    SaleStart = p.SaleStart,
                    SaleEnd = p.SaleEnd,
                    InstructorName = instructorDictionary.ContainsKey(p.InstructorId) ? instructorDictionary[p.InstructorId] : "",
                    EnrolledStudentCount = enrollDictionary.ContainsKey(p.CourseId) ? enrollDictionary[p.CourseId] : 0,
                    AverageRating = ratingDictionary.ContainsKey(p.CourseId) ? ratingDictionary[p.CourseId] : 0,
                }).ToList();

                return coursesDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Get a record by courseId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CourseDetailDTO> GetCourseByIdAsync(int id)
        {
            try
            {
                
                // get course by id
                var course = await _courseRepository.GetByIdAsync(id);
                if (course == null)
                {
                    throw new Exception("Không có khóa học nào");
                }
                //TODO: chua co du lieu cho rating
                // get all topic
                var topics = await _topicRepository.GetAllAsync();
                // get all level
                var levels = await _levelRepository.GetAllAsync();
                // get enrollment student count 
                var enrollCount = await _enrollmentRepository.GetEnrollmentStudentCountAsync(course.CourseId);
                // get average rating 
                var rating = await _courseRatingRepository.GetAverageRating(course.CourseId);
                var user = await _userService.GetUserByIdAsync(course.InstructorId);
                // map to DTO
                var courseDetailDTO = new CourseDetailDTO();
                courseDetailDTO = new CourseDetailDTO
                {
                    CourseId = course.CourseId,
                    CourseName = course.CourseName,
                    ShortDescription = course.ShortDescription,
                    Description = course.Description,
                    TopicName = topics.FirstOrDefault(t => t.TopicId == course.TopicId).TopicName,
                    LevelName = levels.FirstOrDefault(l => l.LevelId == course.LevelId).LevelName,
                    Duration = course.Duration,
                    CourseImage = course.CourseImage,
                    Status = course.Status,
                    Price = course.Price,
                    IsFree = course.IsFree,
                    SalePrice = course.SalePrice,
                    SaleStart = course.SaleStart,
                    SaleEnd = course.SaleEnd,
                    InstructorName = user.FullName,
                    EnrolledStudentCount = enrollCount == null ? 0 : enrollCount,
                    AverageRating = rating == null ? 0 : rating,
                };

                return courseDetailDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Get a record by course name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<CourseDetailDTO> GetCourseByNameAsync(string name)
        {
            try
            {// current user
                var currentUserEmail = _httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(p => p.Type.Contains("email")).Value;
                var currentUser = await _userService.GetUserByEmailAsync(currentUserEmail);

                if (currentUser == null)
                {
                    throw new Exception("Chưa đăng nhập");
                }

                var course = await _courseRepository.GetCourseByNameAsync(name);

                if (course == null)
                {
                    throw new Exception("Không có khóa học nào");
                }

                var topics = await _topicRepository.GetAllAsync();
                var levels = await _levelRepository.GetAllAsync();
                var enrollCount = await _enrollmentRepository.GetEnrollmentStudentCountAsync(course.CourseId);
                var rating = await _courseRatingRepository.GetAverageRating(course.CourseId);


                var courseDetailDTO = new CourseDetailDTO();
                courseDetailDTO = new CourseDetailDTO
                {
                    CourseId = course.CourseId,
                    CourseName = course.CourseName,
                    ShortDescription = course.ShortDescription,
                    Description = course.Description,
                    TopicName = topics.FirstOrDefault(t => t.TopicId == course.TopicId).TopicName,
                    LevelName = levels.FirstOrDefault(l => l.LevelId == course.LevelId).LevelName,
                    Duration = course.Duration,
                    CourseImage = course.CourseImage,
                    Status = course.Status,
                    Price = course.Price,
                    IsFree = course.IsFree,
                    SalePrice = course.SalePrice,
                    SaleStart = course.SaleStart,
                    SaleEnd = course.SaleEnd,
                    InstructorName = currentUser.FullName,
                    EnrolledStudentCount = enrollCount,
                    AverageRating = rating,
                };

                return courseDetailDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Get all record by instructorId
        /// </summary>
        /// <param name="instructorId"></param>
        /// <returns></returns>
        public async Task<List<CourseDetailDTO>> GetAllCourseByInstructorIdAsync(int instructorId)
        {
            try
            {
                // current user
                var currentUserEmail = _httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(p => p.Type.Contains("email")).Value;
                var currentUser = await _userService.GetUserByEmailAsync(currentUserEmail);

                if (currentUser == null)
                {
                    throw new Exception("Chưa đăng nhập");
                }

                var courses = await _courseRepository.GetAllCouresByInstructorIdAsync(instructorId);

                if (courses == null)
                {
                    throw new Exception("Không có khóa học nào");
                }

                var topics = await _topicRepository.GetAllAsync();
                var levels = await _levelRepository.GetAllAsync();
                var enrollCourse = await _enrollmentRepository.GetAllAsync();

                var enrollDictionary = new Dictionary<int, int>();

                foreach (var enroll in enrollCourse)
                {
                    var enrollCount = await _enrollmentRepository.GetEnrollmentStudentCountAsync(enroll.CourseId);
                    enrollDictionary.TryAdd(enroll.CourseId, enrollCount);
                }

                var ratings = await _courseRatingRepository.GetAllAsync();
                var ratingDictionary = new Dictionary<int, double>();
                foreach (var rating in ratings)
                {
                    var avgRating = await _courseRatingRepository.GetAverageRating(rating.CourseId);
                    ratingDictionary.TryAdd(rating.CourseId, avgRating);
                }

                var coursesDTO = new List<CourseDetailDTO>();
                coursesDTO = courses.Select(p => new CourseDetailDTO
                {
                    CourseId = p.CourseId,
                    CourseName = p.CourseName,
                    ShortDescription = p.ShortDescription,
                    Description = p.Description,
                    TopicName = topics.FirstOrDefault(t => t.TopicId == p.TopicId).TopicName,
                    LevelName = levels.FirstOrDefault(l => l.LevelId == p.LevelId).LevelName,
                    Duration = p.Duration,
                    CourseImage = p.CourseImage,
                    Status = p.Status,
                    Price = p.Price,
                    IsFree = p.IsFree,
                    SalePrice = p.SalePrice,
                    SaleStart = p.SaleStart,
                    SaleEnd = p.SaleEnd,
                    InstructorName = currentUser.FullName,
                    EnrolledStudentCount = enrollDictionary.ContainsKey(p.CourseId) ? enrollDictionary[p.CourseId] : 0,
                    AverageRating = ratingDictionary.ContainsKey(p.CourseId) ? ratingDictionary[p.CourseId] : 0,
                    CreatedAt = DateTime.Now,
                }).ToList();

                return coursesDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        #endregion

        #region create, update, delete
        /// <summary>
        /// Create a new record
        /// </summary>
        /// <param name="data"></param>
        /// <param name="topicId"></param>
        /// <param name="levelId"></param>
        /// <returns></returns>
        public async Task<Status> CreateCourseAsync(CourseCreateDTO data)
        {
            try
            {
                //current user
                var currentUserEmail = _httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(p => p.Type.Contains("email")).Value;
                _logger.LogInformation($"user email: {currentUserEmail}");
                var currentUser = await _userService.GetUserByEmailAsync(currentUserEmail);

                if (currentUser == null)
                {
                    return Status.NotFound;
                }

                _logger.LogInformation($"data: " +
                    $"{data.CourseName}\n" +
                    $"{data.ShortDescription}\n" +
                    $"{data.Description}\n" +
                    $"{data.CourseImage}\n" +
                    $"{data.Duration}\n" +
                    $"{data.Price}\n" +
                    $"{data.IsFree}\n" +
                    $"{data.TopicId}\n" +
                    $"{data.LevelId}\n" +
                    $"{data.SalePrice}\n" +
                    $"{data.SaleStart}\n" +
                    $"{data.SaleEnd}\n" +
                    $"{data.Status}");

                var instructorId = currentUser.Id;
                _logger.LogInformation($"id = {instructorId}");

                var addCourse = new Course()
                {
                    CourseName = data.CourseName,
                    ShortDescription = data.ShortDescription,
                    Description = data.Description,
                    InstructorId = instructorId,
                    TopicId = data.TopicId,
                    LevelId = data.LevelId,
                    Duration = data.Duration,
                    CourseImage = data.CourseImage,
                    Status = data.Status,
                    Price = data.Price,
                    IsFree = data.IsFree,
                    SalePrice = data.SalePrice,
                    SaleStart = data.SaleStart,
                    SaleEnd = data.SaleEnd,
                    CreatedAt = DateTime.Now

                };


                var course = await _courseRepository.CreateAsync(addCourse);
                _logger.LogInformation($"fail 1 {course}");
                var detail = await _courseRepository.GetByIdAsync(addCourse.CourseId);
                _logger.LogInformation($"detail {detail.SaleStart}");

                if (course == 0)
                {
                    _logger.LogInformation($"fail 1");
                    return Status.Fail;
                }

                _logger.LogInformation($"fail 1 {addCourse.CourseId}");
                
                return Status.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Update an exist record
        /// </summary>
        /// <param name="data"></param>
        /// <param name="topicId"></param>
        /// <param name="levelId"></param>
        /// <returns></returns>
        public async Task<Status> UpdateCourseAsync(CourseUpdateDTO data)
        {
            try
            {
                //current user
                var currentUserEmail = _httpContextAccessor.HttpContext!.User.Claims
                .FirstOrDefault(p => p.Type.Contains("email"))?.Value;

                // Get the current user
                var currentUser = await _userService.GetUserByEmailAsync(currentUserEmail);

                if (currentUser == null)
                {
                    return Status.NotFound;
                }

                // Get the existing course by ID
                var course = await _courseRepository.GetByIdAsync(data.CourseId);
                if (course == null)
                {
                    return Status.NotFound;
                }

                // Update the course properties
                course.CourseName = data.CourseName;
                course.ShortDescription = data.ShortDescription;
                course.Description = data.Description;
                course.InstructorId = currentUser.Id;
                course.TopicId = data.TopicId;
                course.LevelId = data.LevelId;
                course.Duration = data.Duration;
                course.CourseImage = data.CourseImage;
                course.Status = data.Status;
                course.Price = data.Price;
                course.IsFree = data.IsFree;
                course.SalePrice = data.SalePrice;
                course.SaleStart = data.SaleStart;
                course.SaleEnd = data.SaleEnd;
                course.IsDeleted = false;

                // Update the course in the repository
                var result = await _courseRepository.UpdateAsync(course);

                if (result == 0)
                {
                    return Status.Fail;
                }

                return Status.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Delete an exist record
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<Status> DeleteCourseAsync(CourseDetailDTO data)
        {
            try
            {
                //current user
                var currentUserEmail = _httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(p => p.Type.Contains("email")).Value;
                var currentUser = await _userService.GetUserByEmailAsync(currentUserEmail);

                if (currentUser == null)
                {
                    return Status.NotFound;
                }

                var course = await _courseRepository.GetByIdAsync(data.CourseId);

                var result = await _courseRepository.DeleteAsync(course);

                if (result == 0)
                {
                    return Status.Fail;
                }
                return Status.Success;
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error: {e.Message}");
                throw;
            }
        }

        #endregion

        




    }
}
