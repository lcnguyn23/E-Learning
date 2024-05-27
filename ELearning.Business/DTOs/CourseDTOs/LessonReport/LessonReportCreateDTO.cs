using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.CourseDTOs.LessonReport
{
    public class LessonReportCreateDTO
    {
        public int LessonId { get; set; }
        public int SectionId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public string Content { get; set; }
        public string? ProofImage { get; set; }
        public LessonReportStatus Status { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
