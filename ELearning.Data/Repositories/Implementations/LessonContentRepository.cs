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
    public class LessonContentRepository : Repository<LessonContent>, ILessonContentRepository
    {
        private readonly ELearningDbContext _context;

        public LessonContentRepository(ELearningDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> CreateLessonMediaAsync(LessonMedia lessonMedia)
        {
            _context.Set<LessonMedia>().Add(lessonMedia);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteLessonMediaAsync(LessonMedia lessonMedia)
        {
            _context.Set<LessonMedia>().Remove(lessonMedia);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<LessonMedia>> GetLessonMediasAsync()
        {
            return await _context.LessonMedias.ToListAsync();
        }

        public async Task<LessonMedia> GetLessonMediaByIdAsync(int id)
        {
            return await _context.Set<LessonMedia>().FindAsync(id);
        }

        public async Task<int> UpdateLessonMediaAsync(LessonMedia lessonMedia)
        {
            _context.Entry(lessonMedia).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }

        public async Task<LessonMedia> GetLessonMediaByLessonIdAsync(int lessonId)
        {
            return await _context.Set<LessonMedia>().FirstOrDefaultAsync(l => l.LessonId == lessonId);
        }

        public async Task<LessonContent> GetLessonContentByLessonIdAsync(int lessonId)
        {
            return await _context.Set<LessonContent>().FirstOrDefaultAsync(l => l.LessonId == lessonId);
        }
    }
}
