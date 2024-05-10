using ELearning.Business.Utility;
using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.Services.Interfaces
{
    public interface ISectionService
    {
        Task<List<Section>> GetAllSectionsAsync(int courseId);
        Task<Section> GetSectionByIdAsync(int id);
        Task<Status> CreateSectionAsync(int courseId, Section section);
        Task<Status> UpdateSectionAsync(int courseId, Section section);
        Task<Status> DeleteSectionAsync(int courseId, Section section);
    }
}
