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
    public class CourseRatingRepository : Repository<CourseRating>, ICourseRatingRepository
    {
        private readonly ELearningDbContext _context;
        public CourseRatingRepository(ELearningDbContext context) : base(context)
        {
            _context = context;
        }

        
    }
}
