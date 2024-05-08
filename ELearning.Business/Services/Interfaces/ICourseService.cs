using ELearning.Business.Services.Implementation;
using ELearning.Business.Utility;
using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels;
using ELearning.DomainModels.User;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.Services.Interfaces
{
    public interface ICourseService
    {
        // Course info
        Task<List<Course>> GetAllCoursesAsync();
        Task<Course> GetCourseByIdAsync(int id);
        Task<Status> CreateCourseAsync(Course course, int topicId, int levelId);
        Task<Status> UpdateCourseAsync(Course course, int topicId, int levelId);
        Task<Status> DeleteCourseAsync(Course course);
        Task<Course> GetCourseByNameAsync(string name);

        #region Section 
        Task<List<Section>> GetAllSectionsAsync(int courseId);
        Task<Section> GetSectionByIdAsync(int id);
        Task<Status> CreateSectionAsync(int courseId, Section section);
        Task<Status> UpdateSectionAsync(int courseId, Section section);
        Task<Status> DeleteSectionAsync(int courseId, Section section);
        #endregion

        // Lesson
        Task<List<Lesson>> GetAllLessonsAsync(int sectionId);
        Task<Lesson> GetLessonByIdAsync(int id);
        Task<Status> CreateLessonAsync(int sectionId, Lesson lesson, LessonContent lessonContent, LessonMedia lessonMedia);
        Task<Status> UpdateLessonAsync(int sectionId, Lesson lesson, LessonContent lessonContent, LessonMedia lessonMedia);
        Task<Status> DeleteLessonAsync(int sectionId, Lesson lesson);

        // Quiz
    }
}
