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
    public class LessonReportStatusConfiguration : IEntityTypeConfiguration<LessonReportStatus>
    {
        public void Configure(EntityTypeBuilder<LessonReportStatus> builder)
        {
            // key
            builder
                .ToTable("LessonReportStatus")
                .HasKey(l => l.LessonReportStatusId);

            // properties
            builder
                .Property(l => l.Description)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(l => l.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);
        }
    }
}
