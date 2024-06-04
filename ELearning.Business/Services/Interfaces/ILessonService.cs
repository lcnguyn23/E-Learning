using ELearning.Business.DTOs.CoursesDTOs.LessonContentMedia;
using ELearning.Business.DTOs.CoursesDTOs.Lessons;
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
        Task<List<LessonDetailDTO>> GetAllLessonsBySectionIdAsync(int sectionId);
        Task<LessonDetailDTO> GetLessonByIdAsync(int id);
        
        Task<int> GetLessonIdByTitleAsync(string title);
        Task<int> GetCourseIdAsync(int lessonId);
        Task<Status> CreateLessonAsync(LessonCreateDTO lesson);
        Task<Status> UpdateLessonAsync(LessonUpdateDTO lesson);
        Task<Status> DeleteLessonAsync(int lessonId);
        Task<LessonContentDetailDTO> GetLessonContentByIdAsync(int lessonId);
        Task<Status> CreateLessonContentAsync(LessonContentCreateDTO lessonContent);
        Task<Status> UpdateLessonContentAsync(LessonContentUpdateDTO lessonContent);
        Task<LessonMediaDetailDTO> GetLessonMediaByIdAsync(int lessonId);
        Task<Status> CreateLessonMediaAsync(LessonMediaCreateDTO lessonMedia);
        Task<Status> UpdateLessonMediaAsync(LessonMediaUpdateDTO lessonMedia);
        Task<LessonDetailDTO> GetNextLesson(int sectionId, int lessonId);
    }
}
