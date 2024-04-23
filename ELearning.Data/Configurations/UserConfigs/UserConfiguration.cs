using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.DomainModels;

namespace ELearning.Data.Configurations.UserConfigs
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .ToTable("Users")
                .HasKey(u => u.UserId);

            // relationships config
            //// course - instructor
            builder
                .HasMany(u => u.Courses)
                .WithOne(c => c.Instructor)
                .HasForeignKey(u => u.InstructorId)
                .OnDelete(DeleteBehavior.NoAction);
            //// enrollment
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
            builder
                .HasMany(u => u.CourseRatings)
                .WithOne(c => c.Student)
                .HasForeignKey(u => u.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(u => u.CourseRequests)
                .WithOne(c => c.Instructor)
                .HasForeignKey(u => u.InstructorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(u => u.Discussions)
                .WithOne(d => d.User)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(u => u.DiscussionReplies)
                .WithOne(d => d.User)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(u => u.LessonsReports)
                .WithOne(l => l.Student)
                .HasForeignKey(l => l.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(u => u.StudentLessons)
                .WithOne(s => s.Student)
                .HasForeignKey(u => u.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(u => u.StudentProgresses)
                .WithOne(s => s.Student)
                .HasForeignKey(u => u.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(u => u.QuizAttempts)
                .WithOne(u => u.Student)
                .HasForeignKey(u => u.StudentId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
