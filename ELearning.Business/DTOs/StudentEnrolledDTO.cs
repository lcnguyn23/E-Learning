using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs
{
    public class StudentEnrolledDTO
    {
        public int StudentId { get; set; }
        public string StudentName { get; set;}
        public int CourseId { get; set; }
        public string CourseName { get;set;}
        public int EnrollmentId { get; set; }
    }
}
