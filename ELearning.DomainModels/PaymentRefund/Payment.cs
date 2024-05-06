using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.DomainModels.EnrollmentManagement;

namespace ELearning.DomainModels
{
    public enum PaymentStatus
    {
        COMPLETED,
        FAILED,
        CANCELED,
        REFUNDED,
    }

    public class Payment
    {
        public int PaymentId { get; set; }
        public int EnrollmentId { get; set; }
        public decimal? Amount { get; set; }
        public int PaymentMethodId { get; set; }
        public PaymentStatus Status { get; set; }
        public DateTime? CreatedAt { get; set; }


        // relationships
        public Enrollment Enrollment { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

    }
}
