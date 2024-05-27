using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.CoursesDTOs.LessonContentMedia
{
    public class LessonContentDetailDTO
    {
        public int LessonContentId { get; set; }
        public int LessonId { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
