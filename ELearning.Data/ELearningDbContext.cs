using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.DomainModels;
using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ELearning.DomainModels.EnrollmentManagement;
using ELearning.DomainModels.UserRole;
using Microsoft.AspNetCore.Identity;
using System.Security.Policy;

namespace ELearning.Data
{
    public class ELearningDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int, IdentityUserClaim<int>,
    ApplicationUserRole, IdentityUserLogin<int>,
    IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public ELearningDbContext(DbContextOptions<ELearningDbContext> options) : base(options) { }
        #region
        public DbSet<FavoriteCourse> FavoriteCourses { get; set; }
        public DbSet<StudentProgress> StudentProgresses { get; set; }
        public DbSet<StudentLesson> StudentLessons { get; set; }

        // Course
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseRating> CourseRatings { get; set; }
        public DbSet<CourseRequest> CourseRequests { get; set; }
        public DbSet<CourseRequestStatus> CourseRequestsStatus { get; set; }
        public DbSet<CourseStatus> CourseStatus { get; set; }

        // Topic & Level
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Level> Levels { get; set; }

        // Module
        public DbSet<Section> Sections { get; set; }

        // Lesson
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonContent> LessonContents { get; set; }
        public DbSet<LessonMedia> LessonMedias { get; set; }
        public DbSet<LessonReport> LessonReports { get; set; }
        public DbSet<LessonReportStatus> LessonReportsStatus { get; set; }
        public DbSet<LessonType> LessonTypes { get; set; }

        // Quiz & Question
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuizAttempt> QuizAttempts { get; set; }
        public DbSet<QuizAttemptStatus> QuizAttemptStatus { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionAttempt> QuestionAttempts { get; set; }
        public DbSet<QuestionType> QuestionTypes { get; set; }
        public DbSet<Answer> Answers { get; set; }

        // Media
        public DbSet<Media> Medias { get; set; }
        public DbSet<MediaType> MediaTypes { get; set; }

        // Enrollment
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<EnrollmentStatus> EnrollmentStatus { get; set; }

        // Payment & refund
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<PaymentStatus> PaymentStatus { get; set; }
        public DbSet<RefundRequest> RefundRequests { get; set; }
        public DbSet<RefundStatus> RefundStatus { get; set; }

        // Discussion
        public DbSet<Discussion> Discussions { get; set; }
        public DbSet<DiscussionReply> DiscussionReplies { get; set; }
        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<IdentityUserClaim<int>>(entity =>
            {
                entity.ToTable("UserClaims");
            });
            modelBuilder.Entity<IdentityUserLogin<int>>(entity =>
            {
                entity.ToTable("UserLogins")
                        .HasKey(ul => new { ul.LoginProvider, ul.ProviderKey });
            });
            modelBuilder.Entity<IdentityRoleClaim<int>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            modelBuilder.Entity<IdentityUserToken<int>>(entity =>
            {
                entity.ToTable("UserTokens")
                    .HasKey(ut => new { ut.UserId, ut.LoginProvider, ut.Name });
            });
            #region
            //modelBuilder.Entity<Course>(e =>
            //{
            //    e.ToTable("Courses").HasKey(c => c.CourseId);
            //    e.Property(c => c.Price).HasColumnType("decimal(18,2)");
            //    e.Property(c => c.SalePrice).HasColumnType("decimal(18,2)");
            //    e.HasMany(u => u.FavoriteCourses).WithOne(fc => fc.Course).HasForeignKey(u => u.CourseId).OnDelete(DeleteBehavior.NoAction);
            //});

            //modelBuilder.Entity<Payment>(e =>
            //{
            //    e.ToTable("Payments").HasKey(p => p.PaymentId);
            //    e.Property(p => p.Amount).HasColumnType("decimal(18,2)");

            //});

            //modelBuilder.Entity<RefundRequest>(e =>
            //{
            //    e.ToTable("RefundRequests").HasKey(r => r.RefundRequestId);
            //    e.Property(r => r.RefundAmount).HasColumnType("decimal(18,2)");

            //});

            //modelBuilder.Entity<FavoriteCourse>(e =>
            //{
            //    e.ToTable("FavoriteCourses").HasKey(fc => new { fc.UserId, fc.CourseId });
            //});

            //modelBuilder.Entity<UserRole>(e =>
            //{
            //    e.ToTable("UserRoles").HasKey(ur => new { ur.UserId, ur.RoleId });
            //});

            //modelBuilder.Entity<CourseRating>(e =>
            //{
            //    e.ToTable("CourseRatings").HasKey(cr => new { cr.StudentId, cr.CourseId });
            //    e.HasOne(u => u.Student).WithMany(c => c.CourseRatings).HasForeignKey(u => u.StudentId).OnDelete(DeleteBehavior.NoAction);
            //});

            //modelBuilder.Entity<CourseRequest>(e =>
            //{
            //    e.ToTable("CourseRequests").HasKey(cr => cr.CourseRequestId);
            //    e.HasOne(u => u.Instructor).WithMany(c => c.CourseRequests).HasForeignKey(u => u.InstructorId).OnDelete(DeleteBehavior.NoAction);

            //});

            //modelBuilder.Entity<CourseRequestStatus>(e =>
            //{
            //    e.ToTable("CourseRequestStatus").HasKey(cr => cr.CourseRequestStatusId);
            //});

            //modelBuilder.Entity<DiscussionReply>(e =>
            //{
            //    e.ToTable("DiscussionReplies").HasKey(dr => dr.DiscussionId);
            //    e.HasOne(d => d.Discussion).WithMany(dr => dr.DiscussionReplies).HasForeignKey(d => d.DiscussionId).OnDelete(DeleteBehavior.NoAction);
            //});

            //modelBuilder.Entity<LessonReport>(e =>
            //{
            //    e.ToTable("LessonReports").HasKey(l => l.ReportId);
            //});

            //modelBuilder.Entity<LessonReportStatus>(e =>
            //{
            //    e.ToTable("LessonReportStatus").HasKey(l => l.LessonReportStatusId);
            //});

            //modelBuilder.Entity<RefundRequest>(e =>
            //{
            //    e.ToTable("RefundRequests").HasKey(dr => dr.RefundRequestId);
            //});

            //modelBuilder.Entity<StudentLesson>(e =>
            //{
            //    e.ToTable("StudentLessons").HasKey(s => new { s.StudentId, s.LessonId });
            //});

            //modelBuilder.Entity<StudentProgress>(e =>
            //{
            //    e.ToTable("StudentProgresses").HasKey(s => s.ProgressId);
            //    e.HasOne(s => s.Lesson).WithMany(s => s.StudentProgresses).HasForeignKey(s => s.LessonId).OnDelete(DeleteBehavior.NoAction);
            //    e.HasOne(s => s.Section).WithMany(s => s.StudentProgresses).HasForeignKey(s => s.SectionId).OnDelete(DeleteBehavior.NoAction);
            //    e.HasOne(s => s.Course).WithMany(s => s.StudentProgresses).HasForeignKey(s => s.CourseId).OnDelete(DeleteBehavior.NoAction);

            //});

            //modelBuilder.Entity<QuizAttempt>(e => 
            //{
            //    e.ToTable("QuizAttempts").HasKey(q => q.QuizAttemptId);
            //    e.HasMany(q => q.QuestionAttempts).WithOne(q => q.QuizAttempt).HasForeignKey(q => q.QuizAttemptId).OnDelete(DeleteBehavior.NoAction);
            //});
            #endregion

            modelBuilder.Entity<ApplicationRole>(entity =>
            {
                entity.HasData(
                    new ApplicationRole
                    {
                        Id = 1,
                        Name = "Admin",
                        Description = "",
                        CreatedAt = DateTime.Now,
                    },
                    new ApplicationRole
                    {
                        Id = 2,
                        Name = "Instructor",
                        Description = "",
                        CreatedAt = DateTime.Now,
                    },
                    new ApplicationRole
                    {
                        Id = 3,
                        Name = "Student",
                        Description = "",
                        CreatedAt = DateTime.Now,
                    }
                );
            });

            var hasher = new PasswordHasher<ApplicationUser>();

            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.HasData(
                    new ApplicationUser
                    {
                        Id = 1,
                        FullName = "Lê Trí",
                        BirthDate = DateTime.Now,
                        Gender = true,
                        PhoneNumber = "1234567890",
                        UserName = "admin01@example.com",
                        NormalizedUserName = "admin01",
                        Email = "admin01@example.com",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "P@ssw@rd"),
                    },
                    new ApplicationUser
                    {
                        Id = 2,
                        FullName = "Lê Lai",
                        BirthDate = DateTime.Now,
                        Gender = true,
                        PhoneNumber = "1234567810",
                        UserName = "instructor01@example.com",
                        NormalizedUserName = "instructor01",
                        Email = "instructor01@example.com",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "P@ssw@rd"),
                    },
                    new ApplicationUser
                    {
                        Id = 3,
                        FullName = "Văn Linh",
                        BirthDate = DateTime.Now,
                        Gender = true,
                        PhoneNumber = "1222567890",
                        UserName = "student01@example.com",
                        NormalizedUserName = "student01",
                        Email = "student01@example.com",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "P@ssw@rd"),
                    }
                    );
            });

            modelBuilder.Entity<ApplicationUserRole>(entity =>
            {
                entity.HasData(
                    new ApplicationUserRole
                    {
                        UserId = 1,
                        RoleId = 1
                    },
                    new ApplicationUserRole
                    {
                        UserId = 2,
                        RoleId = 2
                    },
                    new ApplicationUserRole
                    {
                        UserId = 3,
                        RoleId = 3
                    }
                    );
            });
        }

    }
}
