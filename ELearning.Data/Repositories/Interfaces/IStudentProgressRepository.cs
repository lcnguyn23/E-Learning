using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IStudentProgressRepository : IRepository<StudentProgress>
    {
        Task<List<StudentProgress>> GetProgressAsync(int studentId, int courseId);
    }
}
