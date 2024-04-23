using ELearning.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Configurations.CourseConfig
{
    public class CourseRequestStatusConfiguration : IEntityTypeConfiguration<CourseRequestStatus>
    {
        public void Configure(EntityTypeBuilder<CourseRequestStatus> builder)
        {
            // key
            builder
                .ToTable("CourseRequestStatus")
                .HasKey(c => c.CourseRequestStatusId);

            // properties
            builder
                .Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(c => c.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);

            // relationships configuration

        }
    }
}
