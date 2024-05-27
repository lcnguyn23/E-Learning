using ELearning.DomainModels.EnrollmentManagement;
using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.EnrollmentDTOs
{
    public class EnrollmentDetailDTO
    {
        public int Id { get; set; }
        public string CourseName { get; set; } 
        public string StudentName { get; set; } 
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public EnrollmentStatus Status { get; set; }
        public PaymentStatus? PaymentStatus { get; set; }
        public decimal? RefundAmount { get; set; } 
    }
}
