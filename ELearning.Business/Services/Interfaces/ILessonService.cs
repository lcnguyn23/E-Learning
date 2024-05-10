using ELearning.Business.Utility;
using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.Services.Interfaces
{
    public interface ILessonService
    {
        // Lesson
        Task<List<Lesson>> GetAllLessonsAsync(int sectionId);
        Task<Lesson> GetLessonByIdAsync(int id);
        Task<Status> CreateLessonAsync(int sectionId, Lesson lesson, LessonContent lessonContent, LessonMedia lessonMedia);
        Task<Status> UpdateLessonAsync(int sectionId, Lesson lesson, LessonContent lessonContent, LessonMedia lessonMedia);
        Task<Status> DeleteLessonAsync(int sectionId, Lesson lesson);

    }
}
