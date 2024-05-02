using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface ISectionRepository
    {
        Task<List<Section>> GetAllSectionsAsync();
        Task<Section> GetSectionByIdAsync(int id);
        Task<int> CreateSectionAsync(Section section);
        Task<int> UpdateSectionAsync(Section section);
        Task<int> DeleteSectionAsync(int id);
    }
}
