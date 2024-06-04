using ELearning.Business.DTOs.CoursesDTOs.LessonContentMedia;
using ELearning.Business.DTOs.CoursesDTOs.Lessons;
using ELearning.Business.Services.Interfaces;
using ELearning.Business.Utility;
using ELearning.Data.Repositories.Implementations;
using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ELearning.Business.Services.Implementations
{
    public class LessonService : ILessonService
    {
        private readonly ILogger<LessonService> _logger;
        private readonly ILessonRepository _lessonRepository;
        private readonly ILessonContentRepository _lessonContentRepository;

        public LessonService(ILogger<LessonService> logger, ILessonRepository lessonRepository, ILessonContentRepository lessonContentRepository)
        {
            _logger = logger;
            _lessonRepository = lessonRepository;
            _lessonContentRepository = lessonContentRepository;
        }


        public async Task<List<LessonDetailDTO>> GetAllLessonsBySectionIdAsync(int sectionId)
        {
            try
            {
                var lessons = await _lessonRepository.GetAllLessonsBySectionIdAsync(sectionId);

                if (lessons == null)
                {
                    return new List<LessonDetailDTO>();
                }

                var dataList = new List<LessonDetailDTO>();

                foreach (var lesson in lessons)
                {
                    var lessonMedia = await _lessonContentRepository.GetLessonMediaByLessonIdAsync(lesson.LessonId);
                    var lessonContent = await _lessonContentRepository.GetLessonContentByLessonIdAsync(lesson.LessonId);
                    var data = new LessonDetailDTO()
                    {
                        LessonId = lesson.LessonId,
                        SectionId = sectionId,
                        Title = lesson.Title,
                        Order = lesson.Order,
                        LessonContent = lessonContent,
                        LessonMedia = lessonMedia
                    };
                    dataList.Add(data);
                }

                return dataList;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<LessonDetailDTO> GetLessonByIdAsync(int id)
        {
            try
            {
                _logger.LogInformation($"id idi id: {id}");
                var lesson = await _lessonRepository.GetByIdAsync(id);

                _logger.LogInformation($"id idi id: {lesson.LessonId}");
                if (lesson == null)
                {
                    throw new Exception("Không có bài học nào");
                }

                var lessonDTO = new LessonDetailDTO()
                {
                    LessonId = id,
                    SectionId = lesson.SectionId,
                    Title = lesson.Title,
                    Order = lesson.Order,
                    LessonContent = lesson.LessonContent,
                    LessonMedia = lesson.LessonMedia

                };

                return lessonDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        //public async Task<Status> CreateLessonAsync(LessonDetailDTO lesson, LessonContentDetailDTO lessonContent, LessonMediaDetailDTO lessonMedia)
        //{

        //}

        //public async Task<Status> UpdateLessonAsync(int sectionId, LessonDetailDTO lesson, LessonContentDetailDTO lessonContent, LessonMediaDetailDTO lessonMedia)
        //{
        //    try
        //    {
        //        var existingLesson = await _lessonRepository.GetByIdAsync(lesson.LessonId);
        //        if (existingLesson == null)
        //        {
        //            return Status.NotFound; // Lesson not found for update
        //        }

        //        // Update lesson basic info
        //        await _lessonRepository.UpdateAsync(lesson);

        //        if (lessonContent.LessonContentId > 0 && lessonContent.LessonId == lesson.LessonId)
        //        {
        //            await _lessonContentRepository.UpdateAsync(lessonContent);
        //        }
        //        else
        //        {
        //            // Create new lesson content if content is null (optional logic)
        //            lessonContent.LessonId = lesson.LessonId;
        //            await _lessonContentRepository.CreateAsync(lessonContent);
        //        }

        //        // Update lesson media (if provided)
        //        if (lessonMedia != null)
        //        {
        //            if (lessonMedia.LessonMediaId > 0 && lessonMedia.LessonId == lesson.LessonId) // Update existing media if Id is provided
        //            {
        //                lessonMedia.LessonId = lesson.LessonId; // Ensure LessonId is set correctly
        //                await _lessonContentRepository.UpdateLessonMediaAsync(lessonMedia);
        //            }
        //            else
        //            {
        //                // Create new lesson media if Id is not provided (optional logic)
        //                lessonMedia.LessonId = lesson.LessonId;
        //                await _lessonContentRepository.CreateLessonMediaAsync(lessonMedia);
        //            }
        //        }

        //        // Update the lesson in the database
        //        await _lessonRepository.UpdateAsync(existingLesson); // Update the existing lesson

        //        return Status.Success;
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"Error: {ex.Message}");
        //        throw;
        //    }
        //}

        //public async Task<Status> DeleteLessonAsync(int sectionId, Lesson lesson)
        //{
        //    try
        //    {
        //        if (lesson.SectionId != sectionId)
        //        {
        //            return Status.NotFound;
        //        }

        //        var resultLessonDel = await _lessonRepository.DeleteAsync(lesson);

        //        if (resultLessonDel == 0)
        //        {
        //            return Status.Fail;
        //        }

        //        if (lesson.LessonContent != null)
        //        {
        //            await _lessonContentRepository.DeleteAsync(lesson.LessonContent);
        //        }

        //        if (lesson.LessonMedias != null)
        //        {
        //            foreach (var lessonMedia in lesson.LessonMedias)
        //            {
        //                await _lessonContentRepository.DeleteLessonMediaAsync(lessonMedia);
        //            }
        //        }


        //        return Status.Success;
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"Error: {ex.Message}");
        //        throw;
        //    }
        //}

        public async Task<int> GetCourseIdAsync(int lessonId)
        {
            try
            {
                int courseId = await _lessonRepository.GetCourseIdByLessonIdAsync(lessonId);
                return courseId;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<Status> CreateLessonAsync(LessonCreateDTO lesson)
        {
            try
            {
                var newLesson = new Lesson()
                {
                    SectionId = lesson.SectionId,
                    Title = lesson.Title,
                    Order = lesson.Order,
                    CreatedAt = DateTime.Now,
                };
                var result = await _lessonRepository.CreateAsync(newLesson);
                if (result > 0)
                {
                    return Status.Success;
                }

                return Status.Fail;
                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<Status> UpdateLessonAsync(LessonUpdateDTO lesson)
        {
            try
            {
                var newLesson = await _lessonRepository.GetByIdAsync(lesson.LessonId);

                newLesson.LessonId = lesson.LessonId;
                newLesson.SectionId = lesson.SectionId;
                newLesson.Title = lesson.Title;
                newLesson.Order = lesson.Order;
                newLesson.CreatedAt = DateTime.Now;
                
                var result = await _lessonRepository.UpdateAsync(newLesson);
                if (result > 0)
                {
                    return Status.Success;
                }

                return Status.Fail;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<Status> DeleteLessonAsync(int id)
        {
            var data = await _lessonRepository.GetByIdAsync(id);
            var content = await _lessonContentRepository.GetLessonContentByLessonIdAsync(id);
            var media = await _lessonContentRepository.GetLessonMediaByLessonIdAsync(id);

            var resultContent = await _lessonContentRepository.DeleteAsync(content);
            var resultMedia = await _lessonContentRepository.DeleteLessonMediaAsync(media);
            var result = await _lessonRepository.DeleteAsync(data);

            if (result == 0)
            {
                return Status.Fail;
            }

            return Status.Success;
        }

        public async Task<LessonContentDetailDTO> GetLessonContentByIdAsync(int lessonId)
        {
            try
            {
                var content = await _lessonContentRepository.GetLessonContentByLessonIdAsync(lessonId);
                if (content == null)
                {
                    return new LessonContentDetailDTO();
                }
                var contentDTO = new LessonContentDetailDTO()
                {
                    LessonContentId = content.LessonContentId,
                    LessonId = content.LessonId,
                    Description = content.Description,
                    Content = content.Content,
                    CreatedAt = DateTime.Now,
                };
                return contentDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<LessonMediaDetailDTO> GetLessonMediaByIdAsync(int lessonId)
        {
            try
            {
                var media = await _lessonContentRepository.GetLessonMediaByLessonIdAsync(lessonId);
                if (media == null)
                {
                    return new LessonMediaDetailDTO();
                }
                var mediaDTO = new LessonMediaDetailDTO()
                {
                    LessonMediaId = media.LessonMediaId,
                    LessonId = media.LessonId,
                    MediaName = media.MediaName,
                    MediaType = media.MediaType,
                    MediaContent = media.MediaContent,
                    MediaPath = media.MediaPath,
                    MediaUrl = media.MediaUrl,
                };
                return mediaDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        

        public async Task<int> GetLessonIdByTitleAsync(string title)
        {
            try
            {
                int lessonId = await _lessonRepository.GetLessonIdByTitleAsync(title);
                return lessonId;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }


        public async Task<Status> CreateLessonContentAsync(LessonContentCreateDTO lessonContent)
        {
            try
            {
                var newLesson = new LessonContent()
                {
                    LessonId = lessonContent.LessonId,
                    Description = lessonContent.Description,
                    Content = lessonContent.Content,
                    CreatedAt = DateTime.Now,
                };
                var result = await _lessonContentRepository.CreateAsync(newLesson);
                if (result > 0)
                {
                    return Status.Success;
                }

                return Status.Fail;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<Status> UpdateLessonContentAsync(LessonContentUpdateDTO lessonContent)
        {
            try
            {
                var newLesson = await _lessonContentRepository.GetLessonContentByLessonIdAsync(lessonContent.LessonId);

                newLesson.LessonContentId = lessonContent.LessonContentId;
                newLesson.LessonId = lessonContent.LessonId;
                newLesson.Description = lessonContent.Description;
                newLesson.Content = lessonContent.Content;
                newLesson.CreatedAt = DateTime.Now;
                
                var result = await _lessonContentRepository.UpdateAsync(newLesson);
                if (result > 0)
                {
                    return Status.Success;
                }

                return Status.Fail;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<Status> CreateLessonMediaAsync(LessonMediaCreateDTO lessonMedia)
        {
            try
            {
                var newLesson = new LessonMedia()
                {
                    LessonId = lessonMedia.LessonId,
                    MediaName = lessonMedia.MediaName,
                    MediaType = lessonMedia.MediaType,
                    MediaPath = lessonMedia.MediaPath,
                    MediaUrl = lessonMedia.MediaUrl,
                    MediaContent = lessonMedia.MediaContent,
                    FileSizeByte = lessonMedia.FileSize,
                    CreatedAt = DateTime.Now,
                };
                var result = await _lessonContentRepository.CreateLessonMediaAsync(newLesson);
                if (result > 0)
                {
                    return Status.Success;
                }

                return Status.Fail;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<Status> UpdateLessonMediaAsync(LessonMediaUpdateDTO lessonMedia)
        {
            try
            {
                var newLesson = await _lessonContentRepository.GetLessonMediaByLessonIdAsync(lessonMedia.LessonId);

                newLesson.LessonId = lessonMedia.LessonId;
                newLesson.MediaName = lessonMedia.MediaName;
                newLesson.MediaType = lessonMedia.MediaType;
                newLesson.MediaPath = lessonMedia.MediaPath;
                newLesson.MediaUrl = lessonMedia.MediaUrl;
                newLesson.MediaContent = lessonMedia.MediaContent;
                newLesson.FileSizeByte = lessonMedia.FileSize;
                newLesson.CreatedAt = DateTime.Now;
                
                var result = await _lessonContentRepository.UpdateLessonMediaAsync(newLesson);
                if (result > 0)
                {
                    return Status.Success;
                }

                return Status.Fail;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<LessonDetailDTO> GetNextLesson(int sectionId, int lessonId)
        {
            try
            {
                var lesson = await _lessonRepository.GetByIdAsync(lessonId);

                if (lesson == null)
                {
                    throw new Exception("Không có bài học nào");
                }

                var nextLesson = await _lessonRepository.GetNextLessonAsync(sectionId, lessonId);

                var lessonDTO = new LessonDetailDTO()
                {
                    LessonId = nextLesson.LessonId,
                    SectionId = nextLesson.SectionId,
                    Title = nextLesson.Title,
                    Order = nextLesson.Order,
                    LessonContent = nextLesson.LessonContent,
                    LessonMedia = nextLesson.LessonMedia

                };

                return lessonDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }
    }
}
