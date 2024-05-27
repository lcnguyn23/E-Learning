using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels.EnrollmentManagement;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Implementations
{
    public class EnrollmentRepository : Repository<Enrollment>, IEnrollmentRepository
    {
        private readonly ELearningDbContext _context;

        public EnrollmentRepository(ELearningDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> GetEnrollmentStudentCountAsync(int courseId)
        {
            return await _context.Set<Enrollment>().Where(t => t.CourseId == courseId).CountAsync();
        }

        public async Task<Enrollment> GetEnrollmentByCourseIdAsync(int courseId)
        {
            return await _context.Set<Enrollment>().FirstOrDefaultAsync(e => e.CourseId == courseId);
        }
        public async Task<Enrollment> GetEnrollmentByStudentIdAsync(int studentId)
        {
            return await _context.Set<Enrollment>().FirstOrDefaultAsync(e => e.StudentId == studentId);
        }
    }
}
