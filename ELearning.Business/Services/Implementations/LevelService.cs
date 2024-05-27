using ELearning.Business.DTOs.LevelDTOs;
using ELearning.Business.Services.Interfaces;
using ELearning.Data.Repositories.Implementations;
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
    public class LevelService : ILevelService
    {
        private readonly ILogger<LevelService> _logger;
        private readonly ILevelRepository _levelRepository;

        public LevelService(ILogger<LevelService> logger, ILevelRepository levelRepository)
        {
            _logger = logger;
            _levelRepository = levelRepository;
        }

        public async Task<List<LevelDetailDTO>> GetAllLevelsAsync()
        {
            try
            {
                var levels = await _levelRepository.GetAllAsync();

                if (levels == null)
                {
                    throw new Exception("Không có khóa học nào");
                }

                var listLevelDTO = new List<LevelDetailDTO>();

                foreach (var level in levels)
                {
                    var levelDTO = new LevelDetailDTO()
                    {
                        LevelId = level.LevelId,
                        LevelName = level.LevelName,
                        CreatedAt = level.CreatedAt,
                    };
                    listLevelDTO.Add(levelDTO);
                }
                

                return listLevelDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<LevelDetailDTO> GetLevelByIdAsync(int id)
        {
            try
            {
                var level = await _levelRepository.GetByIdAsync(id);

                if (level == null)
                {
                    throw new Exception("Không có khóa học nào");
                }

                var levelDTO = new LevelDetailDTO()
                {
                    LevelId = level.LevelId,
                    LevelName = level.LevelName,   
                    CreatedAt = level.CreatedAt,
                };

                return levelDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<LevelDetailDTO> GetLevelByNameAsync(string name)
        {
            try
            {
                var level = await _levelRepository.GetLevelByNameAsync(name);

                if (level == null)
                {
                    throw new Exception("Không có khóa học nào");
                }
                var levelDTO = new LevelDetailDTO()
                {
                    LevelId = level.LevelId,
                    LevelName = level.LevelName,
                    CreatedAt = level.CreatedAt,
                };

                return levelDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }
    }
}
