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
    public class CourseStatusConfiguration : IEntityTypeConfiguration<CourseStatus>
    {
        public void Configure(EntityTypeBuilder<CourseStatus> builder)
        {
            // key
            builder
                .ToTable("CourseStatus")
                .HasKey(c => c.CourseStatusId);

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
