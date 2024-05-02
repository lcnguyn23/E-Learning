using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface ILessonRepository
    {
        Task<List<Lesson>> GetAllLessonsAsync();
        Task<Lesson> GetLessonByIdAsync(int id);
        Task<int> CreateLessonAsync(Lesson lesson);
        Task<int> UpdateLessonAsync(Lesson lesson);
        Task<int> DeleteLessonAsync(int id);

        // lesson content
        Task<int> CreateLessonContentAsync(LessonContent lessonContent);
        Task<int> UpdateLessonContentAsync(LessonContent lessonContent);
        Task<int> DeleteLessonContentAsync(int id);

        // lesson report
        Task<int> CreateLessonReportAsync(LessonReport lessonReport);
        Task<int> UpdateLessonReportAsync(LessonReport lessonReport);
        Task<int> DeleteLessonReportAsync(int id);

        // lesson media
        Task<int> CreateLessonMediaAsync(LessonMedia lessonMedia);
        Task<int> UpdateLessonMediaAsync(LessonMedia lessonMedia);
        Task<int> DeleteLessonMediaAsync(int id);


    }
}
