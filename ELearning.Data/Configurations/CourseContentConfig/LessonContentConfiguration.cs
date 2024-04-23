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
    public class LessonContentConfiguration : IEntityTypeConfiguration<LessonContent>
    {
        public void Configure(EntityTypeBuilder<LessonContent> builder)
        {
            // key
            builder
                .ToTable("LessonContents")
                .HasKey(l => l.LessonContentId);

            // properties
            builder
                .Property(l => l.Description)
                .HasMaxLength(255);

            builder
                .Property(l => l.Content)
                .HasMaxLength(1000);

            builder
                .Property(l => l.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);
        }
    }
}
