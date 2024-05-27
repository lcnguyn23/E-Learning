using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.CoursesDTOs.Lessons
{
    public class LessonCreateDTO
    {
        public int CourseId { get; set; }
        public int SectionId { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public int LessonContentId { get; set; }
        public int LessonMediaId { get; set; }
    }
}
