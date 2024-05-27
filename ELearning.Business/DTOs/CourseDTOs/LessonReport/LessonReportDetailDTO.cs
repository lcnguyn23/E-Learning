using ELearning.DomainModels.User;
using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.CourseDTOs.LessonReport
{
    public class LessonReportDetailDTO
    {
        public int ReportId { get; set; }
        public int LessonId { get; set; }
        public int LessonName { get; set; }
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Content { get; set; }
        public string? ProofImage { get; set; }
        public LessonReportStatus Status { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
