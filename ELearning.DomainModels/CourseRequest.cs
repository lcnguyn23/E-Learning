using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class CourseRequest
    {
        public int RequestId { get; set; }
        public int CourseId { get; set; }
        public int InstructorId { get; set; }
        public int Status { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime RequestAt { get; set; }
        public DateTime ResponseAt { get; set; }

        // relationships
        public Course Course { get; set; }
        public User Instructor { get; set; }
        public CourseRequestStatus CourseRequestStatus { get; set; }

    }
}
