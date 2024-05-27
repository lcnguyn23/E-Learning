using ELearning.Business.DTOs.CoursesDTOs.Lessons;
using ELearning.Business.DTOs.CoursesDTOs.Sections;
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
    public class SectionService : ISectionService
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly ILessonRepository _lessonRepository;
        private readonly ILogger<SectionService> _logger;

       
        public SectionService(ISectionRepository sectionRepository, ILessonRepository lessonRepository, ILogger<SectionService> logger)
        {
            _sectionRepository = sectionRepository;
            _lessonRepository = lessonRepository;
            _logger = logger;
        }

        public async Task<List<SectionDetailDTO>> GetAllSectionsAsync(int courseId)
        {
            try
            {
                var sections = await _sectionRepository.GetAllSectionsByCourseIdAsync(courseId);
                if (sections == null)
                {
                    throw new Exception("Không có chương nào");
                }

                List<SectionDetailDTO> data = new List<SectionDetailDTO>();

                foreach(var section in sections)
                {

                    var lessonCount = await _lessonRepository.GetAllLessonsBySectionIdAsync(section.SectionId);
                    var sectionDetailDTO = new SectionDetailDTO()
                    {
                        CourseId = courseId,
                        SectionId = section.SectionId,
                        Title = section.Title,
                        SectionOrder = section.SectionOrder,
                        LessonCount = lessonCount.Count(),

                    };
                    data.Add(sectionDetailDTO);
                }

                return data;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<SectionDetailDTO> GetSectionByIdAsync(int id)
        {
            try
            {
                _logger.LogInformation($"int id: {id}");
                var section = await _sectionRepository.GetByIdAsync(id);
                _logger.LogInformation($"int id2: {section.SectionId}");
                var lessonCount = await _lessonRepository.GetAllLessonsBySectionIdAsync(section.SectionId);

                _logger.LogInformation($"int id3: {lessonCount}");
                var sectionDetailDTO = new SectionDetailDTO()
                {
                    CourseId = section.CourseId,
                    SectionId = section.SectionId,
                    Title = section.Title,
                    SectionOrder = section.SectionOrder,
                    LessonCount = lessonCount.Count() == null ? 0 : lessonCount.Count(),
                };
                return sectionDetailDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<Status> CreateSectionAsync(SectionCreateDTO section)
        {
            try
            {
                var sectionData = new Section()
                {
                    CourseId = section.CourseId,
                    Title = section.Title,
                    SectionOrder = section.Order,
                    CreatedAt = DateTime.Now,
                };
                var result = await _sectionRepository.CreateAsync(sectionData);

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

        public async Task<Status> UpdateSectionAsync(SectionUpdateDTO section)
        {
            try
            {
                var sectionData = await _sectionRepository.GetByIdAsync(section.SectionId);

                sectionData.CourseId = section.CourseId;
                sectionData.Title = section.Title;
                sectionData.SectionOrder = section.Order;
                sectionData.CreatedAt = DateTime.Now;
                
                var result = await _sectionRepository.UpdateAsync(sectionData);

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

        public async Task<Status> DeleteSectionAsync(SectionDetailDTO section)
        {
            try
            {
                var data = await _sectionRepository.GetByIdAsync(section.SectionId);
                
                var result = await _sectionRepository.DeleteAsync(data);

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

       
    }
}
