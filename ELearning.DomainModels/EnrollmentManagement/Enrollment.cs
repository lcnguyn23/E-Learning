using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.Data.Interfaces;
using ELearning.DomainModels;
using ELearning.DomainModels.User;

namespace ELearning.DomainModels.EnrollmentManagement
{
    public enum EnrollmentStatus
    {
        ENROLLED,
        IN_PROGRESS,
        COMPLETED,
}

    public class Enrollment : ISoftDelete
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public EnrollmentStatus Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }

        // relationships
        public ApplicationUser Student { get; set; }
        public Course Course { get; set; }
        public RefundRequest RefundRequest { get; set; }
        public Payment Payment { get; set; }

    }
}
