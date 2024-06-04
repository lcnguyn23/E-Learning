using ELearning.Business.DTOs;
using ELearning.Business.DTOs.CourseDTOs.CourseRequest;
using ELearning.Business.DTOs.CoursesDTOs.CourseDetail;
using ELearning.Business.DTOs.StudentProgressDTOs;
using ELearning.Business.DTOs.UserDTOs;
using ELearning.Business.Services.Implementation;
using ELearning.Business.Services.Implementations;
using ELearning.Business.Utility;
using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels;
using ELearning.DomainModels.User;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.Services.Interfaces
{
    public interface ICourseService
    {
        // Course info
        Task<IQueryable<CourseDetailDTO>> GetAllCoursesAsync(string? searchString, int? topicId, int? levelId, CourseStatus? status, int? rating);
        Task<CourseDetailDTO> GetCourseByIdAsync(int id);
        Task<CourseDetailDTO> GetCourseByNameAsync(string name);
        Task<IQueryable<CourseDetailDTO>> GetAllCourseByInstructorIdAsync(int instructorId, string? searchString, int? topicId, int? levelId, CourseStatus? status, int? rating);
        Task<Status> CreateCourseAsync(CourseCreateDTO course);
        Task<Status> UpdateCourseAsync(CourseUpdateDTO course);
        Task<Status> DeleteCourseAsync(CourseDetailDTO course);

        Task<IQueryable<StudentEnrolledDTO>> GetAllStudentEnrolledAsync();
     }
}
