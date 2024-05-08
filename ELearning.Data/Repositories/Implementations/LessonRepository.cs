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
    public class LessonRepository : Repository<Lesson>, ILessonRepository
    {
        private readonly ELearningDbContext _context;

        public LessonRepository(ELearningDbContext context) : base(context)
        {
            _context = context;
        }


        public async Task<List<Lesson>> GetAllLessonsBySectionIdAsync(int sectionId)
        {
            var lessons = await _context.Set<Lesson>().Where(l => l.SectionId == sectionId).ToListAsync();
            return lessons;
        }

    }
}
