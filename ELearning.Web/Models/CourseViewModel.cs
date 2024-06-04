using ELearning.Business.DTOs.CoursesDTOs.CourseDetail;
using ELearning.Web.AppCodes;

namespace ELearning.Web.Models
{
    public class CourseViewModel
    {
        public PaginatedList<CourseDetailDTO> courses {  get; set; }
    }
}
