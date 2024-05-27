using ELearning.Business.DTOs.LevelDTOs;
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
        Task<List<LevelDetailDTO>> GetAllLevelsAsync();
        Task<LevelDetailDTO> GetLevelByIdAsync(int id);
        Task<LevelDetailDTO> GetLevelByNameAsync(string name);
    }
}
