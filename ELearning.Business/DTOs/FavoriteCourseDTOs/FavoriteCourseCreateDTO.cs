using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.FavoriteCourseDTOs
{
    public class FavoriteCourseCreateDTO
    {
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
