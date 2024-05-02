using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IQuizRepository
    {
        Task<List<Quiz>> GetAllQuizzesAsync();
        Task<Quiz> GetQuizByIdAsync(int id);
        Task<int> CreateQuizAsync(Quiz quiz);
        Task<int> UpdateQuizAsync(Quiz quiz);
        Task<int> DeleteQuizAsync(int id);

    }
}
