using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.CourseDTOs.LessonReport
{
    public class LessonReportUpdateDTO
    {
        public int ReportId { get; set; }
        public LessonReportStatus Status { get; set; }
    }
}
