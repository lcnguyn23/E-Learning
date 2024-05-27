using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.StudentProgressDTOs
{
    public class StudentProgressDetailDTO
    {
        public int ProgressId { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int? SectionId { get; set; }
        public string? SectionName { get; set; }
        public int? LessonId { get; set; }
        public string? LessonName { get; set; }
        public long Progress {  get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
