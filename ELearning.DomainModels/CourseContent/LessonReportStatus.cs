using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class LessonReportStatus
    {
        public int StatusId { get; set; }
        public string Description { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        // relationships
        public IEnumerable<LessonReport> LessonReports { get; set; }
    }
}
