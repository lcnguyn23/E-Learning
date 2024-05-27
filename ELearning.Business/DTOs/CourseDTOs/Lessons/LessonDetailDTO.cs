using ELearning.Business.DTOs.CoursesDTOs.LessonContentMedia;
using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.CoursesDTOs.Lessons
{
    public class LessonDetailDTO
    {
        public int LessonId { get; set; }
        public int SectionId { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public LessonContent? LessonContent { get; set; }
        public LessonMedia? LessonMedia { get; set; }
    }
}
