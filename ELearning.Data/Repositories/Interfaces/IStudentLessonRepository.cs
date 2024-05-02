using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IStudentLessonRepository
    {
        Task<List<StudentLesson>> GetAllStudentLesssonsAsync();
        Task<int> CreateStudentLessonAsync(StudentLesson studentLesson);
        Task<int> UpdateStudentLessonAsync(StudentLesson studentLesson);
        Task<int> DeleteStudentLessonAsync(int studentId, int lessonId);
    }
}
