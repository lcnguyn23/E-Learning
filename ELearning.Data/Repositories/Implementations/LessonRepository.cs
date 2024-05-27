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

        public async Task<int> GetCourseIdByLessonIdAsync(int lessonId)
        {
            var courseId = await _context.Lessons
                    .Where(l => l.LessonId == lessonId)
                    .Select(l => l.Section.CourseId)
                    .FirstOrDefaultAsync();

            return courseId;
        }

        public async Task<int> GetLessonIdByTitleAsync(string title)
        {
            var lessonId = await _context.Lessons.Where(l => l.Title.Equals(title)).Select(l => l.LessonId).FirstOrDefaultAsync();
            return lessonId;
        }
    }
}
