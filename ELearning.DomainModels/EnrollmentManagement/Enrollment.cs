using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.DomainModels;
using ELearning.DomainModels.UserRole;

namespace ELearning.DomainModels.EnrollmentManagement
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int EnrollmentStatusId { get; set; }
        public DateTime? CreatedAt { get; set; }


        // relationships
        public ApplicationUser Student { get; set; }
        public Course Course { get; set; }
        public RefundRequest RefundRequest { get; set; }
        public Payment Payment { get; set; }
        public EnrollmentStatus EnrollmentStatus { get; set; }

    }
}
