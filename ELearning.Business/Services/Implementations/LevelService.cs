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

        public async Task<List<Level>> GetAllLevelsAsync()
        {
            try
            {
                var topics = await _levelRepository.GetAllAsync();

                if (topics == null)
                {
                    throw new Exception("Không có khóa học nào");
                }

                return topics;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<Level> GetLevelByIdAsync(int id)
        {
            try
            {
                var topics = await _levelRepository.GetByIdAsync(id);

                if (topics == null)
                {
                    throw new Exception("Không có khóa học nào");
                }

                return topics;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error: {ex.Message}");
                throw;
            }
        }
    }
}
