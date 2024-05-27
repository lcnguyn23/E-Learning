using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.PaymentDTOs.Payment
{
    public class PaymentDetailDTO
    {
        public int PaymentId { get; set; }
        public int EnrollmentId { get; set; }
        public string CourseName { get; set; }
        public string StudentName { get; set; }
        public decimal? Amount { get; set; }
        public string PaymentMethod { get; set; }
        public PaymentStatus Status { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
