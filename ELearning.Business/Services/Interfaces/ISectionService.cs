using ELearning.Business.DTOs.CoursesDTOs.Lessons;
using ELearning.Business.DTOs.CoursesDTOs.Sections;
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
        Task<List<SectionDetailDTO>> GetAllSectionsAsync(int courseId);
        Task<SectionDetailDTO> GetSectionByIdAsync(int id);
        Task<Status> CreateSectionAsync(SectionCreateDTO section);
        Task<Status> UpdateSectionAsync(SectionUpdateDTO section);
        Task<Status> DeleteSectionAsync(SectionDetailDTO section);

        Task<SectionDetailDTO> GetNextSectionAsync(int courseId, int sectionId);
    }
}
