using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Implementations
{
    public class CourseRequestRepository : Repository<CourseRequest>, ICourseRequestRepository
    {
        private readonly ELearningDbContext _context;

        public CourseRequestRepository(ELearningDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<CourseRequest>> GetAllCourseRequestsByInstructorIdAsync(int instructorId)
        {
            return await _context.CourseRequests.Where(p => p.InstructorId == instructorId).ToListAsync();
        }

        public async Task<string> GetCourseRequestNameAsync(int coursesId)
        {
            var courseNames = await _context.CourseRequests
               .Join(_context.Courses, r => r.CourseId, c => c.CourseId, (r, c) => c.CourseName).FirstOrDefaultAsync();
            return courseNames;
        }
    }
}
