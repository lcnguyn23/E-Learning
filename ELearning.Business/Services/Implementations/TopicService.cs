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
    public class TopicService : ITopicService
    {
        private readonly ILogger<TopicService> _logger;
        private readonly ITopicRepository _topicRepository;

        public TopicService(ILogger<TopicService> logger, ITopicRepository topicRepository)
        {
            _logger = logger;
            _topicRepository = topicRepository;
        }

        public async Task<List<Topic>> GetAllTopicsAsync()
        {
            try
            {
                var topics = await _topicRepository.GetAllAsync();

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

        public async Task<Topic> GetTopicByIdAsync(int id)
        {
            try
            {
                var topics = await _topicRepository.GetByIdAsync(id);

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
