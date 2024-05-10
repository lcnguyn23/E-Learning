using ELearning.Business.Services.Interfaces;
using ELearning.Business.Utility;
using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.Services.Implementations
{
    public class LessonService : ILessonService
    {
        private readonly ILogger<LessonService> _logger;
        private readonly ILessonRepository _lessonRepository;
        private readonly ILessonContentRepository _lessonContentRepository;
        private readonly ISectionService _sectionService;

        public LessonService(ILogger<LessonService> logger, ILessonRepository lessonRepository, ISectionService sectionService, ILessonContentRepository lessonContentRepository)
        {
            _logger = logger;
            _lessonRepository = lessonRepository;
            _sectionService = sectionService;
            _lessonContentRepository = lessonContentRepository;
        }

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
                var section = await _sectionService.GetSectionByIdAsync(sectionId);
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
