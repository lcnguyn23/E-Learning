using ELearning.Business.DTOs;

namespace ELearning.Web.Models
{
    public class StudentEnrolledViewModel
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseImage { get; set; }
        public List<StudentEnrolledDTO>? StudentEnrolled { get; set;}
    }
}
