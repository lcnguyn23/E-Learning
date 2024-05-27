using ELearning.Business.DTOs.TopicDTOs;
using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.Services.Interfaces
{
    public interface ITopicService
    {
        Task<List<TopicDetailDTO>> GetAllTopicsAsync();
        Task<TopicDetailDTO> GetTopicByIdAsync(int id);
        Task<TopicDetailDTO> GetTopicByNameAsync(string topicName);
    }
}
