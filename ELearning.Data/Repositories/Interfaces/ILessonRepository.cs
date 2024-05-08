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

        // Lesson type
        //Task<List<LessonType>> GetLessonTypesAsync();
        //Task<LessonType> GetLessonTypeByIdAsync(int id);
        //Task<LessonType> GetLessonTypeByNameAsync(string name);
        //Task<int> CreateLessonTypeAsync(LessonType lessonType);
        //Task<int> UpdateLessonTypeAsync(LessonType lessonType);
        //Task<int> DeleteLessonTypeAsync(LessonType lessonType);
    }
}
