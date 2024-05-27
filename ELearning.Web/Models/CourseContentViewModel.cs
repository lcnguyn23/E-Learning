using ELearning.Business.DTOs.CoursesDTOs.CourseDetail;
using ELearning.Business.DTOs.CoursesDTOs.Lessons;
using ELearning.Business.DTOs.CoursesDTOs.Sections;

namespace ELearning.Web.Models
{
    public class CourseContentViewModel
    {
        public CourseDetailDTO CourseDetail { get; set; }
        public List<SectionDetailDTO> SectionDetails { get; set; }
    }
}
