using ELearning.DomainModels.EnrollmentManagement;

namespace ELearning.Web.Models
{
    public class EnrollCourseListViewModel
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string InstructorName { get; set; }
        public DateTime? EnrollAt { get; set; }
        public EnrollmentStatus EnrollmentStatus { get; set; }
    }
}
