using ELearning.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Configurations.CourseContentConfig
{
    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            // key
            builder
                .ToTable("Lessons")
                .HasKey(l => l.LessonId);

            // properties
            builder
                .Property(l => l.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(l => l.CreatedAt)
                .HasColumnType("datetime2");
        }
    }
}
