using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IAnswerRepository
    {
        Task<List<Answer>> GetAllAnswersAsync();
        Task<Answer> GetAnswerByIdAnsync(int id);
        Task<int> CreateAnswerAsync(Answer answer);
        Task<int> UpdateAnswerASync(Answer answer);
        Task<int> DeleteAnswerAsync(int id);
    }
}
