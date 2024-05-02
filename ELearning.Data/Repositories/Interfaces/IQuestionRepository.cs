using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IQuestionRepository
    {
        Task<List<Question>> GetAllQuestionsAsync();
        Task<Question> GetQuestionByIdAsync(int id);
        Task<int> CreateQuestionAsync(Question question);
        Task<int> UpdateQuestionAsync(Question question);
        Task<int> DeleteQuestionAsync(int id);
    }
}
