using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.Data.Interfaces;
using ELearning.DomainModels.EnrollmentManagement;

namespace ELearning.DomainModels
{
    public enum RefundStatus {
        APPROVED,
        DENIED,
        CANCELED,
        COMPLETED,
        FAILED
    }


    public class RefundRequest : ISoftDelete
    {
        public int RefundRequestId { get; set;}
        public int EnrollmentId { get; set;}
        public decimal RefundAmount { get; set;}
        public string? RefundReason { get; set;}
        public RefundStatus Status { get; set;}
        public string? Note { get; set;}
        public DateTime? ApprovalAt { get; set;}
        public DateTime? CreatedAt { get; set;}
        public bool IsDeleted { get; set;} = false;
        public DateTime? DeletedAt { get; set; }


        // relationships
        public Enrollment Enrollment { get; set;}
        
    }
}
