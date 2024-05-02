using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IFavoriteCourseRepository
    {
        Task<List<FavoriteCourse>> GetAllFavoriteCoursesAsync();
        Task<FavoriteCourse> GetFavoriteCourseByIdAsync(int id);
        Task<int> CreateFavoriteCourseAsync(FavoriteCourse course);
        Task<int> DeleteFavoriteCourseAsync(int id);
    }
}
