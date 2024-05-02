using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface ICourseRatingRepository
    {
        Task<List<CourseRating>> GetAllCourseRatingsAsync();
        Task<List<CourseRating>> GetAllCourseRatingsByPoint(int ratingPoint);
        Task<CourseRating> GetCourseRatingByIdAsync(int id);
        Task<int> CreateCourseRatingAsync(CourseRating courseRating);
        Task<int> UpdateCourseRatingAsync(CourseRating courseRating);
        Task<int> DeleteCourseRatingAsync(int id);
    }
}
