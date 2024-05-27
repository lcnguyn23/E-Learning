using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.CoursesDTOs.CourseDetail
{
    public class CourseListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string InstructorName { get; set; }
        public CourseStatus Status { get; set; }
        public int EnrollmentCount { get; set; }
        public int SectionCount { get; set; } 
        public int LessonCount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
    }
}

