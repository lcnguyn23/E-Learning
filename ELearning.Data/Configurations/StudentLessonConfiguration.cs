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
    public class StudentLessonConfiguration : IEntityTypeConfiguration<StudentLesson>
    {
        public void Configure(EntityTypeBuilder<StudentLesson> builder)
        {
            // key
            builder
                .ToTable("StudentLessons")
                .HasKey(s => new { s.StudentId, s.LessonId });

            // properties
            builder
                .Property(s => s.CompletedAt)
                .HasColumnType("datetime2");
        }
    }
}
