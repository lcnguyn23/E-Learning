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
        private readonly ILogger<SectionService> _logger;

        public SectionService(ISectionRepository sectionRepository, ILogger<SectionService> logger)
        {
            _sectionRepository = sectionRepository;
            _logger = logger;
        }

        public async Task<List<Section>> GetAllSectionsAsync(int courseId)
        {
            try
            {
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
                    throw new Exception("Không có chương nào");
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
            }
            catch (Exception ex)
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
    }
}
