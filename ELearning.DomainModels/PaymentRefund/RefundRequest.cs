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
        public int RefundId { get; set;}
        public int EnrollmentId { get; set;}
        public decimal RefundAmount { get; set;}
        public string RefundReason { get; set;}
        public int Status { get; set;}
        public string Note { get; set;}

        [DataType(DataType.DateTime)]
        public DateTime ApprovalAt { get; set;}

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set;} = DateTime.Now;

        // relationships
        public Enrollment Enrollment { get; set;}
        public RefundStatus RefundStatus { get; set;}
        
    }
}
