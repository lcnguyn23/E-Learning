using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.StudentProgressDTOs
{
    public class StudentProgressCreateDTO
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int? SectionId { get; set; }
        public int? LessonId { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
