using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.DomainModels;
using System.Reflection;

namespace ELearning.Data
{
    public class ELearningDbContext : DbContext
    {
        public ELearningDbContext(DbContextOptions<ELearningDbContext> options) : base(options) { }
        #region
        // User & Role
        DbSet<User> Users { get; set; }
        DbSet<UserRole> UserRoles { get; set; }
        DbSet<UserStatus> UserStatus { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<FavoriteCourse> FavoriteCourses { get; set; }
        DbSet<StudentProgress> StudentProgresses { get; set; }
        DbSet<StudentLesson> StudentLessons { get; set; }

        // Course
        DbSet<Course> Courses { get; set; }
        DbSet<CourseRating> CourseRatings { get; set; }
        DbSet<CourseRequest> CourseRequests { get; set; }
        DbSet<CourseRequestStatus> CourseRequestsStatus { get; set; }
        DbSet<CourseStatus> CourseStatus { get; set; }

        // Topic & Level
        DbSet<Topic> Topics { get; set; }
        DbSet<Level> Levels { get; set; }

        // Module
        DbSet<Section> Sections { get; set; }

        // Lesson
        DbSet<Lesson> Lessons { get; set; }
        DbSet<LessonContent> LessonsContents { get; set; }
        DbSet<LessonMedia> LessonsMedias { get; set; }
        DbSet<LessonReport> LessonsReports { get; set; }
        DbSet<LessonReportStatus> LessonsReportsStatus { get; set; }
        DbSet<LessonType> LessonsTypes { get; set; }

        // Quiz & Question
        DbSet<Quiz> Quizes { get; set; }
        DbSet<QuizAttempt> QuizAttempts { get; set; }
        DbSet<QuizAttemptStatus> QuizAttemptStatus { get; set; }
        DbSet<Question> Questions { get; set; }
        DbSet<QuestionAttempt> QuestionAttempts { get; set; }
        DbSet<QuestionType> QuestionTypes { get; set; }
        DbSet<Answer> Answers { get; set; }

        // Media
        DbSet<Media> Medias { get; set; }
        DbSet<MediaType> MediaTypes { get; set; }

        // Enrollment
        DbSet<Enrollment> Enrollments { get; set; }
        DbSet<EnrollmentStatus> EnrollmentsStatus { get; set; }

        // Payment & refund
        DbSet<Payment> Payments { get; set; }
        DbSet<PaymentMethod> PaymentMethods { get; set; }
        DbSet<PaymentStatus> PaymentStatus { get; set; }
        DbSet<RefundRequest> RefundRequests { get; set; }
        DbSet<RefundStatus> RefundStatus { get; set; }

        // Discussion
        DbSet<Discussion> Discussions { get; set; }
        DbSet<DiscussionReply> DiscussionReplies { get; set; }
        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
            modelBuilder.Entity<Course>(e =>
            {
                e.ToTable("Courses").HasKey(c => c.CourseId);
                e.Property(c => c.Price).HasColumnType("decimal(18,2)");
                e.Property(c => c.SalePrice).HasColumnType("decimal(18,2)");
                e.HasMany(u => u.FavoriteCourses).WithOne(fc => fc.Course).HasForeignKey(u => u.CourseId).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Payment>(e =>
            {
                e.ToTable("Payments").HasKey(p => p.PaymentId);
                e.Property(p => p.Amount).HasColumnType("decimal(18,2)");

            });

            modelBuilder.Entity<RefundRequest>(e =>
            {
                e.ToTable("RefundRequests").HasKey(r => r.RefundId);
                e.Property(r => r.RefundAmount).HasColumnType("decimal(18,2)");

            });

            modelBuilder.Entity<FavoriteCourse>(e =>
            {
                e.ToTable("FavoriteCourses").HasKey(fc => new { fc.UserId, fc.CourseId });
            });

            //modelBuilder.Entity<UserRole>(e =>
            //{
            //    e.ToTable("UserRoles").HasKey(ur => new { ur.UserId, ur.RoleId });
            //});

            modelBuilder.Entity<CourseRating>(e =>
            {
                e.ToTable("CourseRatings").HasKey(cr => new { cr.StudentId, cr.CourseId });
                e.HasOne(u => u.Student).WithMany(c => c.CourseRatings).HasForeignKey(u => u.StudentId).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<CourseRequest>(e =>
            {
                e.ToTable("CourseRequests").HasKey(cr => cr.RequestId);
                e.HasOne(u => u.Instructor).WithMany(c => c.CourseRequests).HasForeignKey(u => u.InstructorId).OnDelete(DeleteBehavior.NoAction);

            });

            modelBuilder.Entity<CourseRequestStatus>(e =>
            {
                e.ToTable("CourseRequestStatus").HasKey(cr => cr.RequestStatusId);
            });

            modelBuilder.Entity<DiscussionReply>(e =>
            {
                e.ToTable("DiscussionReplies").HasKey(dr => dr.DiscussionId);
                e.HasOne(d => d.Discussion).WithMany(dr => dr.DiscussionReplies).HasForeignKey(d => d.DiscussionId).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<LessonReport>(e =>
            {
                e.ToTable("LessonReports").HasKey(l => l.ReportId);
            });

            modelBuilder.Entity<LessonReportStatus>(e =>
            {
                e.ToTable("LessonReportStatus").HasKey(l => l.StatusId);
            });

            modelBuilder.Entity<RefundRequest>(e =>
            {
                e.ToTable("RefundRequests").HasKey(dr => dr.RefundId);
            });

            modelBuilder.Entity<StudentLesson>(e =>
            {
                e.ToTable("StudentLessons").HasKey(s => new { s.StudentId, s.LessonId });
            });

            modelBuilder.Entity<StudentProgress>(e =>
            {
                e.ToTable("StudentProgresses").HasKey(s => s.ProgressId);
                e.HasOne(s => s.Lesson).WithMany(s => s.StudentProgresses).HasForeignKey(s => s.LessonId).OnDelete(DeleteBehavior.NoAction);
                e.HasOne(s => s.Section).WithMany(s => s.StudentProgresses).HasForeignKey(s => s.SectionId).OnDelete(DeleteBehavior.NoAction);
                e.HasOne(s => s.Course).WithMany(s => s.StudentProgresses).HasForeignKey(s => s.CourseId).OnDelete(DeleteBehavior.NoAction);

            });

            modelBuilder.Entity<QuizAttempt>(e => 
            {
                e.ToTable("QuizAttempts").HasKey(q => q.QuizAttemptId);
                e.HasMany(q => q.QuestionAttempts).WithOne(q => q.QuizAttempt).HasForeignKey(q => q.QuizAttemptId).OnDelete(DeleteBehavior.NoAction);
            });
        }

    }
}
