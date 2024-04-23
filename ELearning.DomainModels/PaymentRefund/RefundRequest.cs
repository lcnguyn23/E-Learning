using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.DomainModels.EnrollmentManagement;

namespace ELearning.DomainModels
{
    public class RefundRequest
    {
        public int RefundRequestId { get; set;}
        public int EnrollmentId { get; set;}
        public decimal RefundAmount { get; set;}
        public string? RefundReason { get; set;}
        public int RefundStatusId { get; set;}
        public string? Note { get; set;}
        public DateTime? ApprovalAt { get; set;}
        public DateTime? CreatedAt { get; set;}

        // relationships
        public Enrollment Enrollment { get; set;}
        public RefundStatus RefundStatus { get; set;}
    }
}
