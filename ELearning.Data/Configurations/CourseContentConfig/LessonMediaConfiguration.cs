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
    public class LessonMediaConfiguration : IEntityTypeConfiguration<LessonMedia>
    {
        public void Configure(EntityTypeBuilder<LessonMedia> builder)
        {
            // key
            builder
                .ToTable("LessonMedias")
                .HasKey(l => l.LessonMediaId);

            // properties
            builder
                .Property(l => l.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);
        }
    }
}
