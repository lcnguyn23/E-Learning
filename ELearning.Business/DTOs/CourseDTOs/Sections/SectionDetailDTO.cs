using ELearning.Business.DTOs.CoursesDTOs.Lessons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.CoursesDTOs.Sections
{
    public class SectionDetailDTO
    {
        public int CourseId { get; set; }
        public int SectionId { get; set; }
        public string Title { get; set; }
        public int SectionOrder { get; set; }
        public int LessonCount { get; set; }
        public int? QuizCount { get; set; }
        public List<LessonDetailDTO>? Lessons { get; set; }
    }
}
