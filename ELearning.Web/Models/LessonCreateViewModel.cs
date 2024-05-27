using ELearning.Business.DTOs.CoursesDTOs.LessonContentMedia;

namespace ELearning.Web.Models
{
    public class LessonCreateViewModel
    {
        public int LessonId { get; set; }
        public int CourseId { get; set; }
        public int SectionId { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public LessonContentDetailDTO? LessonContent { get; set; }
        public LessonMediaDetailDTO? LessonMedia { get; set; }
        
    }
}
