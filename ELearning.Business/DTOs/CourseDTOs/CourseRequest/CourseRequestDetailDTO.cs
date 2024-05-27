using ELearning.DomainModels.User;
using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.CourseDTOs.CourseRequest
{
    public class CourseRequestDetailDTO
    {
        public int CourseRequestId { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public CourseRequestStatus Status { get; set; }
        public DateTime? RequestAt { get; set; }
        public DateTime? ResponseAt { get; set; }
    }
}
