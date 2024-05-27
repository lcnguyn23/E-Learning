using ELearning.DomainModels.EnrollmentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.EnrollmentDTOs
{
    public class EnrollmentUpdateDTO
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public EnrollmentStatus Status { get; set; }
    }
}
