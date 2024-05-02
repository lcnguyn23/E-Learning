using ELearning.DomainModels.EnrollmentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IEnrollmentRepository
    {
        Task<List<Enrollment>> GetAllEnrollmentsAsync();
        Task<Enrollment> GetEnrollmentsByIdAsync(int id);
        Task<int> CreateEnrollmentAsync(Enrollment enrollment);
        Task<int> UpdateEnrollmentAsync(Enrollment enrollment);
        Task<int> DeleteEnrollmentAsync(int id);
    }
}
