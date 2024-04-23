using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.DomainModels;
using ELearning.DomainModels.EnrollmentManagement;

namespace ELearning.DomainModels
{
    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string? ProfileImage { get; set; }
        public string? Bio { get; set; }
        public int Status { get; set; }
        public DateTime? CreatedAt { get; set; }


        // relationships
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
        public IEnumerable<FavoriteCourse> FavoriteCourses { get; set; }
        public IEnumerable<UserRole> UserRoles { get; set; }
        public IEnumerable<CourseRequest> CourseRequests { get; set; }
        public IEnumerable<CourseRating> CourseRatings { get; set; }
        public UserStatus UserStatus { get; set; }
        public IEnumerable<QuizAttempt> QuizAttempts { get; set; }
        public IEnumerable<Discussion> Discussions { get; set; }
        public IEnumerable<DiscussionReply> DiscussionReplies { get; set; }
        public IEnumerable<StudentLesson> StudentLessons { get; set; }
        public IEnumerable<StudentProgress> StudentProgresses { get; set; }
        public IEnumerable<LessonReport> LessonsReports { get; set; }

    }
}
