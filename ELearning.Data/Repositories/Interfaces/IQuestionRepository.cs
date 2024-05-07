using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IQuestionRepository : IRepository<Question>
    {

        // Question type
        Task<List<QuestionType>> GetAllQuestionTypeAsync();
        Task<QuestionType> GetQuestionTypeByIdAsync(int id);
        Task<QuestionType> GetQuestionTypeByNameAsync(string name);
        Task<int> CreateQuestionTypeAsync(QuestionType questionType);
        Task<int> UpdateQuestionTypeAsync(QuestionType questionType);
        Task<int> DeleteQuestionTypeAsync(QuestionType questionType);
    }
}
