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
        private readonly ILogger _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly ICourseRepository _courseRepository;
        private readonly IUserService _userService;
        private readonly ISectionRepository _sectionRepository;
        private readonly ILessonRepository _lessonRepository;
        private readonly ILessonContentRepository _lessonContentRepository;
        private readonly ITopicRepository _topicRepository;
        private readonly ILevelRepository _levelRepository;
        private readonly IQuizRepository _quizRepository;


        public CourseService(ILogger logger, 
            IHttpContextAccessor httpContextAccessor, 
            ICourseRepository courseRepository, 
            IUserService userService, 
            ISectionRepository sectionRepository, 
            ILessonRepository lessonRepository, 
            ILessonContentRepository lessonContentRepository, 
            IQuizRepository quizRepository)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _courseRepository = courseRepository;
            _userService = userService;
            _sectionRepository = sectionRepository;
            _lessonRepository = lessonRepository;
            _lessonContentRepository = lessonContentRepository;
            _quizRepository = quizRepository;
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

        #endregion

        #region Section
        public async Task<List<Section>> GetAllSectionsAsync(int courseId)
        {
            try { 
                var sections = await _sectionRepository.GetAllSectionsByCourseIdAsync(courseId);
                if (sections == null)
                {
                    throw new Exception("Không có chương nào");
                }

                return sections;
            } 
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<Section> GetSectionByIdAsync(int id)
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

                var courses = await _sectionRepository.GetByIdAsync(id);

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

        public async Task<Status> CreateSectionAsync(int id, Section section)
        {
            try
            {
                if (section.CourseId != id)
                {
                    return Status.NotFound;
                }

                var result = await _sectionRepository.CreateAsync(section);
                
                if (result == 0)
                {
                    return Status.Fail;
                }

                return Status.Success;
            } catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<Status> UpdateSectionAsync(int id, Section section)
        {
            try
            {
                if (section.CourseId != id)
                {
                    return Status.NotFound;
                }

                var result = await _sectionRepository.UpdateAsync(section);

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

        public async Task<Status> DeleteSectionAsync(int id, Section section)
        {
            try
            {
                if (section.CourseId != id)
                {
                    return Status.NotFound;
                }

                var result = await _sectionRepository.DeleteAsync(section);

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
        #endregion

        public async Task<List<Lesson>> GetAllLessonsAsync(int sectionId)
        {
            try
            {
                var lessons = await _lessonRepository.GetAllLessonsBySectionIdAsync(sectionId);

                if (lessons == null)
                {
                    throw new Exception("Không có bài học nào");
                }

                return lessons;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<Lesson> GetLessonByIdAsync(int id)
        {
            try
            {
                var lessons = await _lessonRepository.GetByIdAsync(id);

                if (lessons == null)
                {
                    throw new Exception("Không có bài học nào");
                }

                return lessons;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<Status> CreateLessonAsync(int sectionId, Lesson lesson, LessonContent lessonContent, LessonMedia lessonMedia)
        {
            try
            {
                var section = await _sectionRepository.GetByIdAsync(sectionId);
                if (section == null)
                {
                    return Status.NotFound;
                }

                lesson.SectionId = section.SectionId;
                var newLesson = await _lessonRepository.CreateAsync(lesson); // ID of new lesson
                if (newLesson == 0)
                {
                    return Status.Fail;
                }

                lessonMedia.LessonId = newLesson; 
                var lessonMediaContent = await _lessonContentRepository.CreateLessonMediaAsync(lessonMedia);
                if (lessonMediaContent == 0)
                {
                    _logger.LogError("Failed to create lesson media.");
                    return Status.Fail; 
                }

                lessonContent.LessonId = newLesson;
                var content = await _lessonContentRepository.CreateAsync(lessonContent);
                if (content == 0)
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

        public async Task<Status> UpdateLessonAsync(int sectionId, Lesson lesson, LessonContent lessonContent, LessonMedia lessonMedia)
        {
            try
            {
                var existingLesson = await _lessonRepository.GetByIdAsync(lesson.LessonId);
                if (existingLesson == null)
                {
                    return Status.NotFound; // Lesson not found for update
                }

                // Update lesson basic info
                await _lessonRepository.UpdateAsync(lesson);

                if (lessonContent.LessonContentId > 0 && lessonContent.LessonId == lesson.LessonId)
                {
                    await _lessonContentRepository.UpdateAsync(lessonContent);
                }
                else
                {
                    // Create new lesson content if content is null (optional logic)
                    lessonContent.LessonId = lesson.LessonId;
                    await _lessonContentRepository.CreateAsync(lessonContent);
                }

                // Update lesson media (if provided)
                if (lessonMedia != null)
                {
                    if (lessonMedia.LessonMediaId > 0 && lessonMedia.LessonId == lesson.LessonId) // Update existing media if Id is provided
                    {
                        lessonMedia.LessonId = lesson.LessonId; // Ensure LessonId is set correctly
                        await _lessonContentRepository.UpdateLessonMediaAsync(lessonMedia);
                    }
                    else
                    {
                        // Create new lesson media if Id is not provided (optional logic)
                        lessonMedia.LessonId = lesson.LessonId;
                        await _lessonContentRepository.CreateLessonMediaAsync(lessonMedia);
                    }
                }

                // Update the lesson in the database
                await _lessonRepository.UpdateAsync(existingLesson); // Update the existing lesson

                return Status.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<Status> DeleteLessonAsync(int sectionId, Lesson lesson)
        {
            try
            {
                if (lesson.SectionId != sectionId)
                {
                    return Status.NotFound;
                }

                var resultLessonDel = await _lessonRepository.DeleteAsync(lesson);
                
                if (resultLessonDel == 0)
                {
                    return Status.Fail;
                }

                if (lesson.LessonContent != null)
                {
                    await _lessonContentRepository.DeleteAsync(lesson.LessonContent);
                }
                
                if (lesson.LessonMedias != null)
                {
                    foreach (var lessonMedia in lesson.LessonMedias)
                    {
                        await _lessonContentRepository.DeleteLessonMediaAsync(lessonMedia);
                    }
                } 
                    

                return Status.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        
    }
}
