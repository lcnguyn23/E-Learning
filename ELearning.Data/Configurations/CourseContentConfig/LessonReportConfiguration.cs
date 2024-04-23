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
    public class LessonReportConfiguration : IEntityTypeConfiguration<LessonReport>
    {
        public void Configure(EntityTypeBuilder<LessonReport> builder)
        {
            // key
            builder
                .ToTable("LessonReports")
                .HasKey(l => l.ReportId);

            // properties
            builder
                .Property(l => l.Content)
                .IsRequired()
                .HasMaxLength(200);

            builder
                .Property(l => l.ProofImage)
                .HasMaxLength(2000);

            builder
                .Property(l => l.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);
        }
    }
}
