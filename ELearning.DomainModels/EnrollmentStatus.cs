using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class EnrollmentStatus
    {
        public int EnrollmentStatusId { get; set; }
        public string Description { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        // relationships
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}
