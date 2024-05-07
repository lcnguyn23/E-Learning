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

        public async Task<int> CreateLessonTypeAsync(LessonType lessonType)
        {
            _context.Set<LessonType>().Add(lessonType);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteLessonTypeAsync(LessonType lessonType)
        {
            _context.Set<LessonType>().Remove(lessonType);
            return await _context.SaveChangesAsync();
        }

        public async Task<LessonType> GetLessonTypeByIdAsync(int id)
        {
            return await _context.Set<LessonType>().FindAsync(id);
        }

        public async Task<LessonType> GetLessonTypeByNameAsync(string name)
        {
            var type = await _context.LessonTypes.FirstOrDefaultAsync(t => t.TypeName.Equals(name));
            return type;
        }

        public async Task<List<LessonType>> GetLessonTypesAsync()
        {
            return await _context.LessonTypes.ToListAsync();
        }

        public async Task<int> UpdateLessonTypeAsync(LessonType lessonType)
        {
            _context.Entry(lessonType).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }
    }
}
