using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels.EnrollmentManagement;
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
    }
}
