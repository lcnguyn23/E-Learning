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
    public class SectionRepository : Repository<Section>, ISectionRepository
    {
        private readonly ELearningDbContext _context;

        public SectionRepository(ELearningDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Section>> GetAllSectionsByCourseIdAsync(int courseId)
        {
            var sections = await _context.Sections.Where(s => s.CourseId == courseId).ToListAsync();
            return sections;
        }

        public async Task<Section> GetNextSectionAsync(int courseId, int sectionId)
        {
            
            var section = await _context.Sections.FirstOrDefaultAsync(p => p.CourseId == courseId && p.SectionId == sectionId);
            var nextSection = await _context.Sections.Where(p => p.CourseId == courseId && p.SectionOrder == section.SectionOrder + 1).FirstOrDefaultAsync();

            return nextSection;
        }
    }
}
