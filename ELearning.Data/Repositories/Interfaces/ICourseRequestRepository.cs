using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface ICourseRequestRepository : IRepository<CourseRequest>
    {
        Task<List<CourseRequest>> GetAllCourseRequestsByInstructorIdAsync(int instructorId);
        Task<string> GetCourseRequestNameAsync(int coursesId);
    }
}
