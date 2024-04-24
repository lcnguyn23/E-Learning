using ELearning.DomainModels.EnrollmentManagement;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels.UserRole
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        public string? ProfilePicture { get; set; }
        public string? Bio { get; set; }
        public DateTime? CreatedAt { get; set; }

        // relationships
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
        public IEnumerable<FavoriteCourse> FavoriteCourses { get; set; }
        public IEnumerable<CourseRequest> CourseRequests { get; set; }
        public IEnumerable<CourseRating> CourseRatings { get; set; }
        public IEnumerable<QuizAttempt> QuizAttempts { get; set; }
        public IEnumerable<Discussion> Discussions { get; set; }
        public IEnumerable<DiscussionReply> DiscussionReplies { get; set; }
        public IEnumerable<StudentLesson> StudentLessons { get; set; }
        public IEnumerable<StudentProgress> StudentProgresses { get; set; }
        public IEnumerable<LessonReport> LessonsReports { get; set; }

        ///
        //public IEnumerable<IdentityUserClaim<int>> UserClaims { get; set; }
        //public IEnumerable<IdentityUserLogin<int>> UserLogins { get; set; }
        //public IEnumerable<IdentityUserToken<int>> UserTokens { get; set; }
        public IEnumerable<ApplicationUserRole> UserRoles { get; set; }
    }
}
