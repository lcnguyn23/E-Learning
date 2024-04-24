using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.DomainModels;
using ELearning.DomainModels.UserRole;

namespace ELearning.DomainModels
{
    public class CourseRequest
    {
        public int CourseRequestId { get; set; }
        public int CourseId { get; set; }
        public int InstructorId { get; set; }
        public int CourseRequestStatusId { get; set; }
        public DateTime? RequestAt { get; set; }
        public DateTime? ResponseAt { get; set; }

        // relationships
        public Course Course { get; set; }
        public ApplicationUser Instructor { get; set; }
        public CourseRequestStatus CourseRequestStatus { get; set; }

    }
}
