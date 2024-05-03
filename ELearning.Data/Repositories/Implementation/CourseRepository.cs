using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Implementation
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ELearningDbContext _context;

        public CourseRepository(ELearningDbContext context)
        {
            _context = context;
        }

        public Task<int> CreateAsync(Course entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Course>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Course> GetByIdAnsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Course> GetCourseByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateASync(Course entity)
        {
            throw new NotImplementedException();
        }

        //public async Task<List<Course>> GetAllCoursesAsync()
        //{
        //    var courses = await _context.Courses!.ToListAsync();
        //    return courses;
        //}

        //public async Task<Course> GetCourseByIdAsync(int id)
        //{
        //    var course = await _context.Courses!
        //        .FirstOrDefaultAsync(c => c.CourseId == id);
        //    return course;
        //}

        //public async Task<Course> GetCourseByNameAsync(string name)
        //{
        //    var course = await _context.Courses!
        //        .FirstOrDefaultAsync(c => c.CourseName.Equals(name));
        //    return course;
        //}

        //public Task<int> CreateCourseAsync(Course course)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<int> UpdateCourseAsync(Course course)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<int> DeleteCourseAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}



    }
}
