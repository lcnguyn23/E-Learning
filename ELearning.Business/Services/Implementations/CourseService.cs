using ELearning.Business.Services.Implementation;
using ELearning.Business.Services.Interfaces;
using ELearning.Business.Utility;
using ELearning.Data.Repositories;
using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Section = ELearning.DomainModels.Section;

namespace ELearning.Business.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly ILogger<CourseService> _logger;
        //private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly ICourseRepository _courseRepository;
        //private readonly IUserService _userService;

        public CourseService(ILogger<CourseService> logger, ICourseRepository courseRepository)
        {
            _logger = logger;
           // _httpContextAccessor = httpContextAccessor;
            _courseRepository = courseRepository;
           // _userService = userService;
        }




        #region CourseInfo
        public async Task<List<Course>> GetAllCoursesAsync()
        {
            try
            {
                // current user
                //var currentUserName = _httpContextAccessor.HttpContext!.Items["UserName"]?.ToString();
                //var currentUser = await _userService.GetUserByUserNameAsync(currentUserName);

                //if (currentUser == null)
                //{
                //    return Status.NotFound;
                //}

                var courses = await _courseRepository.GetAllAsync();

                if (courses == null)
                {
                    throw new Exception("Không có khóa học nào");
                }

                return courses;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            try
            {
                // current user
                //var currentUserName = _httpContextAccessor.HttpContext!.Items["UserName"]?.ToString();
                //var currentUser = await _userService.GetUserByUserNameAsync(currentUserName);

                //if (currentUser == null)
                //{
                //    return Status.NotFound;
                //}

                var courses = await _courseRepository.GetByIdAsync(id);

                if (courses == null)
                {
                    throw new Exception("Không có khóa học nào");
                }

                return courses;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<Course> GetCourseByNameAsync(string name)
        {
            try
            {
                // current user
                //var currentUserName = _httpContextAccessor.HttpContext!.Items["UserName"]?.ToString();
                //var currentUser = await _userService.GetUserByUserNameAsync(currentUserName);

                //if (currentUser == null)
                //{
                //    return Status.NotFound;
                //}

                var courses = await _courseRepository.GetCourseByNameAsync(name);

                if (courses == null)
                {
                    throw new Exception("Không có khóa học nào");
                }

                return courses;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<Status> CreateCourseAsync(Course data, int topicId, int levelId)
        {
            try
            {
                // current user
                //var currentUserName = _httpContextAccessor.HttpContext!.Items["UserName"]?.ToString();
                //var currentUser = await _userService.GetUserByUserNameAsync(currentUserName);

                //if (currentUser == null)
                //{
                //    return Status.NotFound;
                //}

                data.TopicId = topicId;
                data.LevelId = levelId;
                data.InstructorId = 2; // test id

                var course = await _courseRepository.CreateAsync(data);

                if (course == 0)
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

        public async Task<Status> UpdateCourseAsync(Course data, int topicId, int levelId)
        {
            try
            {
                // current user
                //var currentUserName = _httpContextAccessor.HttpContext!.Items["UserName"]?.ToString();
                //var currentUser = await _userService.GetUserByUserNameAsync(currentUserName);

                //if (currentUser == null)
                //{
                //    return Status.NotFound;
                //}

                var course = await _courseRepository.GetByIdAsync(data.CourseId);
                if (course == null)
                {
                    return Status.NotFound;
                }

                data.TopicId = topicId;
                data.LevelId = levelId;

                var updateCourse = await _courseRepository.UpdateAsync(data);

                if (updateCourse == 0)
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

        public async Task<Status> DeleteCourseAsync(Course data)
        {
            try
            {
                var result = await _courseRepository.DeleteAsync(data);
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

        public async Task<List<Course>> GetAllCourseByInstructorIdAsync(int instructorId)
        {
            try
            {
                // current user
                //var currentUserName = _httpContextAccessor.HttpContext!.Items["UserName"]?.ToString();
                //var currentUser = await _userService.GetUserByUserNameAsync(currentUserName);

                //if (currentUser == null)
                //{
                //    return Status.NotFound;
                //}

                var courses = await _courseRepository.GetAllCouresByInstructorIdAsync(instructorId);

                if (courses == null)
                {
                    throw new Exception("Không có khóa học nào");
                }

                return courses;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        #endregion






    }
}
