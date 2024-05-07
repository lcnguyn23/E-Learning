using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface ILessonContentRepository : IRepository<LessonContent>
    {


        // Lesson media
        Task<List<LessonMedia>> GetLessonMediasAsync();
        Task<LessonMedia> GetLessonMediaByIdAsync(int id);
        Task<int> CreateLessonMediaAsync(LessonMedia lessonMedia);
        Task<int> UpdateLessonMediaAsync(LessonMedia lessonMedia);
        Task<int> DeleteLessonMediaAsync(LessonMedia lessonMedia);

        
    }
}
