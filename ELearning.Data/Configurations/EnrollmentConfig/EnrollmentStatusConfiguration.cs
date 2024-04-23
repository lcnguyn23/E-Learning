using ELearning.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Configurations.EnrollmentConfig
{
    internal class EnrollmentStatusConfiguration : IEntityTypeConfiguration<EnrollmentStatus>
    {
        public void Configure(EntityTypeBuilder<EnrollmentStatus> builder)
        {
            // key
            builder
                .ToTable("EnrollmentStatus")
                .HasKey(e => e.EnrollmentStatusId);

            // properties
            builder
                .Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(e => e.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);
        }
    }
}
