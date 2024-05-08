using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.Data.Interfaces;
using ELearning.DomainModels;
using ELearning.DomainModels.User;

namespace ELearning.DomainModels
{
    public enum CourseRequestStatus
    {
        PENDING,
        APPROVED,
        DENIED,
        CANCELED
    }
    public class CourseRequest : ISoftDelete
    {
        public int CourseRequestId { get; set; }
        public int CourseId { get; set; }
        public int InstructorId { get; set; }
        public CourseRequestStatus Status { get; set; }
        public DateTime? RequestAt { get; set; }
        public DateTime? ResponseAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }

        // relationships
        public Course Course { get; set; }
        public ApplicationUser Instructor { get; set; }

    }
}
