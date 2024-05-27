using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.CourseDTOs.LessonReport
{
    public class LessonReportListDTO
    {
        public int ReportId { get; set; }
        public string CourseName { get; set; }
        public string StudentName { get; set; }
        public string Content { get; set; }
        public LessonReportStatus Status { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
