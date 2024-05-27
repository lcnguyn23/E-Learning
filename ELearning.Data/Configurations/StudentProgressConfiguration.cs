using ELearning.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Configurations
{
    public class StudentProgressConfiguration : IEntityTypeConfiguration<StudentProgress>
    {
        public void Configure(EntityTypeBuilder<StudentProgress> builder)
        {
            // key
            builder
                .ToTable("StudentProgresses")
                .HasKey(s => s.ProgressId);

            // properties
            builder
                .Property(s => s.CreatedAt)
                .HasColumnType("datetime2");

            // relationships configuration
            builder
                .HasOne(s => s.Lesson)
                .WithMany(s => s.StudentProgresses)
                .HasForeignKey(s => s.LessonId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(s => s.Section)
                .WithMany(s => s.StudentProgresses)
                .HasForeignKey(s => s.SectionId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(s => s.Course)
                .WithMany(s => s.StudentProgresses)
                .HasForeignKey(s => s.CourseId)
                .OnDelete(DeleteBehavior.NoAction);
            

        }
    }
}
