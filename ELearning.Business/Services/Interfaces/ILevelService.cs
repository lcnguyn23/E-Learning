using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.Services.Interfaces
{
    public interface ILevelService
    {
        Task<List<Level>> GetAllLevelsAsync();
        Task<Level> GetLevelByIdAsync(int id);
    }
}
