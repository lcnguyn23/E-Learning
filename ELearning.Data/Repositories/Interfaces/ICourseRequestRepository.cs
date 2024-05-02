using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface ICourseRequestRepository
    {
        Task<List<CourseRequest>> GetAllCourseRequestAsync();
        Task<CourseRequest> GetCourseRequestByIdAsync(int id);
        Task<int> CreateCourseRequestAsync(CourseRequest courseRequest);
        Task<int> UpdateCourseRequestAsync(CourseRequest courseRequest);
        Task<int> DeleteCourseRequestAsync(int id);
    }
}
