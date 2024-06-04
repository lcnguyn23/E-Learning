using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface ILessonRepository : IRepository<Lesson>
    {
        // Lesson

        Task<List<Lesson>> GetAllLessonsBySectionIdAsync(int sectionId);
        Task<int> GetCourseIdByLessonIdAsync(int lessonId);
        Task<int> GetLessonIdByTitleAsync(string title);

        Task<Lesson> GetNextLessonAsync(int sectionId, int lessonId);
    }
}
