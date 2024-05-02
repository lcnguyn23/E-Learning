using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetAllCoursesAsync();
        Task<Course> GetCourseByIdAsync(int id);
        Task<Course> GetCourseByNameAsync(string name);
        Task<int> CreateCourseAsync(Course course);
        Task<int> UpdateCourseAsync(Course course);
        Task<int> DeleteCourseAsync(int id);
        
        
        


        
    }
}
