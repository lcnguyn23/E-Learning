using ELearning.DomainModels;
using ELearning.DomainModels.EnrollmentManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Configurations.EnrollmentConfig
{
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            // key
            builder
                .ToTable("Enrollments")
                .HasKey(e => e.EnrollmentId);

            // properties
            builder
                .Property(e => e.StartDate)
                .HasColumnType("datetime2");

            builder
                .Property(e => e.EndDate)
                .HasColumnType("datetime2");

            builder
                .Property(e => e.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);

            // relationships configuration

            // Status
            builder
                .Property(c => c.Status)
                .HasConversion(
                    s => s.ToString(),
                    s => (EnrollmentStatus)Enum.Parse(typeof(EnrollmentStatus), s)
                );
        }
    }
}
