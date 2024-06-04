using ELearning.DomainModels.EnrollmentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IEnrollmentRepository : IRepository<Enrollment>
    {
        Task<int> GetEnrollmentStudentCountAsync(int courseId);
        Task<Enrollment> GetEnrollmentByCourseIdAsync(int courseId);
        Task<List<Enrollment>> GetEnrollmentsByStudentIdAsync(int studentId);

        Task<Enrollment> GetEnrollmentByStudentIdAsync(int studentId);
        Task<Enrollment> GetEnrollmentByCourseAndStudentAsync(int studentId, int courseId);
    }
}
