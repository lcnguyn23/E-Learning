using ELearning.Business.DTOs.CourseDTOs.CourseRequest;
using ELearning.Business.DTOs.CoursesDTOs;
using ELearning.Business.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.Services.Interfaces
{
    public interface ICourseRequestService
    {
        Task<List<CourseRequestListDTO>> GetAllCourseRequestsAsync();
        Task<CourseRequestDetailDTO> GetCourseRequestByIdAsync(int id);
        Task<CourseRequestCreateDTO> GetCourseRequestByNameAsync(string name);
        Task<List<CourseRequestListDTO>> GetAllCourseRequestsByInstructorIdAsync(int instructorId);
        Task<Status> CreateCourseRequestAsync(CourseRequestCreateDTO course);
        Task<Status> UpdateCourseRequestAsync(CourseRequestUpdateDTO course);
        Task<Status> DeleteCourseRequestAsync(CourseRequestDetailDTO course);
    }
}
