using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.DomainModels;
using ELearning.DomainModels.UserRole;

namespace ELearning.Data.Configurations.UserConfig
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            // key
            builder
                .ToTable("Users")
                .HasKey(u => u.Id);

            // properties

            builder
                .Property(u => u.FullName)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(u => u.BirthDate)
                .IsRequired()
                .HasColumnType("date");

            builder
                .Property(u => u.Gender)
                .IsRequired();

            builder
                .Property(u => u.UserName)
                .IsRequired();

            builder
                .Property(u => u.Email)
                .IsRequired();

            builder
                .Property(u => u.PhoneNumber)
                .IsRequired();


            builder
                .Property(u => u.ProfilePicture)
                .HasMaxLength(2048);  

            builder
                .Property(u => u.Bio)
                .HasMaxLength(500);

            builder
                .Property(u => u.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);
                                            

            // relationships configuration
            // course - instructor
            builder
                .HasMany(u => u.Courses)
                .WithOne(c => c.Instructor)
                .HasForeignKey(u => u.InstructorId)
                .OnDelete(DeleteBehavior.NoAction);

            // enrollment
            builder
                .HasMany(u => u.Enrollments)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            // favorite course
            builder
                .HasMany(u => u.FavoriteCourses)
                .WithOne(fc => fc.User)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            // user role
            builder
                .HasMany(u => u.UserRoles)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            // course rating
            builder
                .HasMany(u => u.CourseRatings)
                .WithOne(c => c.Student)
                .HasForeignKey(u => u.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            // course request
            builder
                .HasMany(u => u.CourseRequests)
                .WithOne(c => c.Instructor)
                .HasForeignKey(u => u.InstructorId)
                .OnDelete(DeleteBehavior.NoAction);

            // discussion
            builder
                .HasMany(u => u.Discussions)
                .WithOne(d => d.User)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            // discussion reply
            builder
                .HasMany(u => u.DiscussionReplies)
                .WithOne(d => d.User)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            // lesson report
            builder
                .HasMany(u => u.LessonsReports)
                .WithOne(l => l.Student)
                .HasForeignKey(l => l.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            // student lesson
            builder
                .HasMany(u => u.StudentLessons)
                .WithOne(s => s.Student)
                .HasForeignKey(u => u.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            // student progresses
            builder
                .HasMany(u => u.StudentProgresses)
                .WithOne(s => s.Student)
                .HasForeignKey(u => u.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            // quiz attempts
            builder
                .HasMany(u => u.QuizAttempts)
                .WithOne(u => u.Student)
                .HasForeignKey(u => u.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            
        }
    }
}
