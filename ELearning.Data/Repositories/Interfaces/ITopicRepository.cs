using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface ITopicRepository
    {
        Task<List<Topic>> GetAllTopicsAsync();
        Task<Topic> GetTopicByIdAsync(int id);
        Task<int> CreateTopicAsync(Topic topic);
        Task<int> UpdateTopicAsync(Topic topic);
        Task<int> DeleteTopicAsync(int id);
    }
}
