using ELearning.Business.Services.Implementation;
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
        Task<List<Course>> GetAllCoursesAsync();
        Task<Course> GetCourseByIdAsync(int id);
        Task<Course> GetCourseByNameAsync(string name);
        Task<List<Course>> GetAllCourseByInstructorIdAsync(int instructorId);
        Task<Status> CreateCourseAsync(Course course, int topicId, int levelId);
        Task<Status> UpdateCourseAsync(Course course, int topicId, int levelId);
        Task<Status> DeleteCourseAsync(Course course);
        
    }
}
