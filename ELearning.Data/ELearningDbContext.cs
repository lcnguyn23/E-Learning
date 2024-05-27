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
using ELearning.DomainModels.User;
using Microsoft.AspNetCore.Identity;
using System.Security.Policy;

namespace ELearning.Data
{
    public class ELearningDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int, IdentityUserClaim<int>,
    IdentityUserRole<int>, IdentityUserLogin<int>,
    IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public ELearningDbContext(DbContextOptions<ELearningDbContext> options) : base(options) { }
        #region
        public DbSet<FavoriteCourse> FavoriteCourses { get; set; }
        public DbSet<StudentProgress> StudentProgresses { get; set; }

        // Course
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseRating> CourseRatings { get; set; }
        public DbSet<CourseRequest> CourseRequests { get; set; }

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
        //public DbSet<LessonType> LessonTypes { get; set; }

        // Quiz & Question
        //public DbSet<Quiz> Quizzes { get; set; }
        //public DbSet<QuizAttempt> QuizAttempts { get; set; }
        //public DbSet<Question> Questions { get; set; }
        //public DbSet<QuestionAttempt> QuestionAttempts { get; set; }
        //public DbSet<QuestionType> QuestionTypes { get; set; }
        //public DbSet<Answer> Answers { get; set; }

        // Media
        //public DbSet<Media> Medias { get; set; }
        //public DbSet<MediaType> MediaTypes { get; set; }

        // Enrollment
        public DbSet<Enrollment> Enrollments { get; set; }

        // Payment & refund
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<RefundRequest> RefundRequests { get; set; }

        // Discussion
        public DbSet<Discussion> Discussions { get; set; }
        public DbSet<DiscussionReply> DiscussionReplies { get; set; }

        // notification
        public DbSet<Notification> Notifications { get; set; }
        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<IdentityRole<int>>(entity =>
            {
                entity.ToTable("Roles");
            });
            modelBuilder.Entity<IdentityUserRole<int>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
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


            // Role seed data
            modelBuilder.Entity<IdentityRole<int>>(entity =>
            {
                entity.HasData(
                    new IdentityRole<int>
                    {
                        Id = 1,
                        Name = "Admin",
                        NormalizedName = "ADMIN",
                    },
                    new IdentityRole<int>
                    {
                        Id = 2,
                        Name = "Instructor",
                        NormalizedName = "INSTRUCTOR",
                    },
                    new IdentityRole<int>
                    {
                        Id = 3,
                        Name = "Student",
                        NormalizedName = "STUDENT",
                    }
                );
            });

            var hasher = new PasswordHasher<ApplicationUser>();

            // // user seed data
            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.HasData(
                    new ApplicationUser
                    {
                        Id = 1,
                        FullName = "Lê Trí",
                        BirthDate = DateTime.Now,
                        Gender = Gender.Male,
                        PhoneNumber = "1234567890",
                        UserName = "admin01@example.com",
                        NormalizedUserName = "admin01",
                        Email = "admin01@example.com",
                        NormalizedEmail = "admin01@example.com",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "P@ssw@rd"),
                    },
                    new ApplicationUser
                    {
                        Id = 2,
                        FullName = "Lê Lai",
                        BirthDate = DateTime.Now,
                        Gender = Gender.Male,
                        PhoneNumber = "1234567810",
                        UserName = "instructor01@example.com",
                        NormalizedUserName = "instructor01",
                        Email = "instructor01@example.com",
                        NormalizedEmail = "instructor01@example.com",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "P@ssw@rd"),
                    },
                    new ApplicationUser
                    {
                        Id = 3,
                        FullName = "Văn Linh",
                        BirthDate = DateTime.Now,
                        Gender = Gender.Male,
                        PhoneNumber = "1222567890",
                        UserName = "student01@example.com",
                        NormalizedUserName = "student01",
                        Email = "student01@example.com",
                        NormalizedEmail = "student01@example.com",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "P@ssw@rd"),
                    },
                    new ApplicationUser
                    {
                        Id = 12,
                        FullName = "Nguyễn Linh",
                        BirthDate = DateTime.Now,
                        Gender = Gender.Male,
                        PhoneNumber = "1234522810",
                        UserName = "linhlinhins11@example.com",
                        NormalizedUserName = "linhlinhins11@example.com",
                        Email = "linhlinhins11@example.com",
                        NormalizedEmail = "linhlinhins11@example.com",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "P@ssw@rd"),
                    },
                    new ApplicationUser
                    {
                        Id = 13,
                        FullName = "Hồ Linh",
                        BirthDate = DateTime.Now,
                        Gender = Gender.Male,
                        PhoneNumber = "12312567890",
                        UserName = "studentlinh11@example.com",
                        NormalizedUserName = "studentlinh11@example.com",
                        Email = "studentlinh11@example.com",
                        NormalizedEmail = "studentlinh11@example.com",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "P@ssw@rd"),
                    }
                    );
            });

            // user role
            modelBuilder.Entity<IdentityUserRole<int>>(entity =>
            {
                entity.HasData(
                    new IdentityUserRole<int>
                    {
                        UserId = 1,
                        RoleId = 1
                    },
                    new IdentityUserRole<int>
                    {
                        UserId = 2,
                        RoleId = 2
                    },
                    new IdentityUserRole<int>
                    {
                        UserId = 3,
                        RoleId = 3
                    },
                    new IdentityUserRole<int>
                    {
                        UserId = 12,
                        RoleId = 2
                    },
                    new IdentityUserRole<int>
                    {
                        UserId = 13,
                        RoleId = 3
                    }
                    );
            });

            // // topic seed data
            modelBuilder.Entity<Topic>(entity =>
            {
                entity.HasData(
                    new Topic
                    {
                        TopicId = 1,
                        TopicName = "Công nghệ thông tin",
                    },
                    new Topic
                    {
                        TopicId = 2,
                        TopicName = "Nhiếp ảnh"
                    },
                    new Topic
                    {
                        TopicId = 3,
                        TopicName = "Mỹ thuật"
                    },
                    new Topic
                    {
                        TopicId = 4,
                        TopicName = "Digital marketing"
                    },
                    new Topic
                    {
                        TopicId = 5,
                        TopicName = "Âm nhạc"
                    }

                );
            });
            // // level seed data
            modelBuilder.Entity<Level>(entity =>
            {
                entity.HasData(
                    new Level
                    {
                        LevelId = 1,
                        LevelName = "Cơ bản",
                    },
                    new Level
                    {
                        LevelId = 2,
                        LevelName = "Trung cấp"
                    },
                    new Level
                    {
                        LevelId = 3,
                        LevelName = "Nâng cao"
                    },
                    new Level
                    {
                        LevelId = 4,
                        LevelName = "Mọi cấp độ"
                    }

                 );
            });
            // // course seed data
            modelBuilder.Entity<Course>(entity =>
           {
               entity.HasData(
                   new Course
                   {
                       CourseId = 1,
                       CourseName = "Lập trình C# cơ bản",
                       Description = "Khóa học mang đến những kiến thức cơ bản về C#",
                       InstructorId = 2,
                       TopicId = 1,
                       LevelId = 1,
                       Duration = "10 tiếng",
                       CourseImage = "",
                       Price = 100000,
                       IsFree = false,
                       Status = CourseStatus.PUBLISH,
                   },
                   new Course
                   {
                       CourseId = 2,
                       CourseName = "Guitar cơ bản",
                       Description = "Khóa học cơ bản về Guitar",
                       InstructorId = 2,
                       TopicId = 5,
                       LevelId = 1,
                       Duration = "20 tiếng",
                       CourseImage = "",
                       Price = 100000,
                       IsFree = false,
                       Status = CourseStatus.PUBLISH,
                   },
                   new Course
                   {
                       CourseId = 3,
                       CourseName = "SEO cơ bản",
                       Description = "Khóa học SEO cơ bản cho website",
                       InstructorId = 2,
                       TopicId = 4,
                       LevelId = 1,
                       Duration = "30 tiếng",
                       CourseImage = "",
                       Price = 100000,
                       IsFree = false,
                       Status = CourseStatus.PUBLISH,
                   }

               );
           });
            // section seed data
            modelBuilder.Entity<Section>(entity =>
            {
                entity.HasData(
                    new Section
                    {
                        SectionId = 1,
                        CourseId = 1,
                        Title = "Basic syntax",
                        SectionOrder = 1

                    },
                    new Section
                    {
                        SectionId = 2,
                        CourseId = 1,
                        Title = "Basic syntax 2",
                        SectionOrder = 2

                    },
                    new Section
                    {
                        SectionId = 3,
                        CourseId = 2,
                        Title = "Giới thiệu",
                        SectionOrder = 1

                    },
                    new Section
                    {
                        SectionId = 4,
                        CourseId = 2,
                        Title = "Tìm hiểu về đàn Guitar",
                        SectionOrder = 2

                    }
                );
            });
            // // lesson seed data
            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.HasData(
                    new Lesson
                    {
                        LessonId = 1,
                        SectionId = 1,
                        Title = "Lesson 1",
                        Order = 1

                    },
                    new Lesson
                    {
                        LessonId = 2,
                        SectionId = 1,
                        Title = "Lesson 2",
                        Order = 2

                    },
                    new Lesson
                    {
                        LessonId = 3,
                        SectionId = 2,
                        Title = "Lesson 3",
                        Order = 1

                    },
                    new Lesson
                    {
                        LessonId = 4,
                        SectionId = 2,
                        Title = "Lesson 4",
                        Order = 2

                    },
                    new Lesson
                    {
                        LessonId = 5,
                        SectionId = 2,
                        Title = "Lesson 5",
                        Order = 3

                    }
                );
            });
            modelBuilder.Entity<LessonContent>(entity =>
            {
                entity.HasData(
                    new LessonContent
                    {
                        LessonContentId = 1,
                        LessonId = 1,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."

                    },
                    new LessonContent
                    {
                        LessonContentId = 2,
                        LessonId = 2,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."

                    },
                    new LessonContent
                    {
                        LessonContentId = 3,
                        LessonId = 3,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."

                    }
                );
            });

            //
            modelBuilder.Entity<LessonMedia>(entity =>
            {
                entity.HasData(
                    new LessonMedia
                    {
                        LessonMediaId = 1,
                        LessonId = 1,
                        MediaName = "ytbCourse1",
                        MediaContent = "<iframe width=\"875\" height=\"492\" src=\"https://www.youtube.com/embed/DZFne4v2Z4Q?list=RDDZFne4v2Z4Q\" title=\"JVKE - This Is What Slow Dancing Feels Like (Lyrics)\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                        MediaType = MediaType.Embed
                    },
                    new LessonMedia
                    {
                        LessonMediaId = 2,
                        LessonId = 2,
                        MediaName = "ytbCourse2",
                        MediaContent = "<iframe width=\"875\" height=\"492\" src=\"https://www.youtube.com/embed/DZFne4v2Z4Q?list=RDDZFne4v2Z4Q\" title=\"JVKE - This Is What Slow Dancing Feels Like (Lyrics)\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>",
                        MediaType = MediaType.Embed
                    }
                );
            });

            //string date_string = "2024-05-09 15:58:49.6334339";
            //string date2 = "2024-05-15 15:58:49.6334339";
            //string format_string = "yyyy-MM-dd HH:mm:ss.fffffff";

            //DateTime date_time_obj = DateTime.ParseExact(date_string, format_string, null);
            //DateTime date_time_2 = DateTime.ParseExact(date2, format_string, null);

            //modelBuilder.Entity<Enrollment>(entity =>
            //{
            //    entity.HasData(
            //        new Enrollment
            //        {
            //            EnrollmentId = 1,
            //            StudentId = 3,
            //            CourseId = 1,
            //            StartDate = date_time_obj,
            //            Status = EnrollmentStatus.IN_PROGRESS,
            //        },
            //        new Enrollment
            //        {
            //            EnrollmentId = 2,
            //            StudentId = 13,
            //            CourseId = 3,
            //            StartDate = date_time_2,
            //            Status = EnrollmentStatus.ENROLLED,

            //        }
            //    );
            //});
        }

    }
}
