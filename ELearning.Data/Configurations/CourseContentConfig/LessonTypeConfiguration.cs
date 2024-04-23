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
    public class LessonTypeConfiguration : IEntityTypeConfiguration<LessonType>
    {
        public void Configure(EntityTypeBuilder<LessonType> builder)
        {
            // key
            builder
                .ToTable("LessonTypes")
                .HasKey(l => l.LessonTypeId);

            // properties
            builder
                .Property(l => l.TypeName)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(l => l.Description)
                .HasMaxLength(100);

            builder
                .Property(l => l.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);
        }
    }
}
