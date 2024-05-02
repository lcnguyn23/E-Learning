using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface ILevelRepository
    {
        Task<List<Level>> GetAllLevelsAsync();
        Task<Level> GetLevelByIdAsync(int id);
        Task<int> CreateLevelcAsync(Level level);
        Task<int> UpdateLevelAsync(Level level);
        Task<int> DeleteLevelAsync(int id);
    }
}
