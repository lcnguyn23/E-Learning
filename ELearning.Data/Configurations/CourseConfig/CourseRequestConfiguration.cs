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
    public class CourseRequestConfiguration : IEntityTypeConfiguration<CourseRequest>
    {
        public void Configure(EntityTypeBuilder<CourseRequest> builder)
        {
            // key
            builder
                .ToTable("CourseRequests")
                .HasKey(c => c.CourseRequestId);

            // properties
            builder
                .Property(c => c.RequestAt)
                .HasColumnType("datetime2");

            builder
                .Property(c => c.ResponseAt)
                .HasColumnType("datetime2");

            // relationships configuration
            builder
                .HasOne(u => u.Instructor)
                .WithMany(c => c.CourseRequests)
                .HasForeignKey(u => u.InstructorId)
                .OnDelete(DeleteBehavior.NoAction);

            // status (enum)
            builder
                .Property(c => c.Status)
                .HasConversion(
                    s => s.ToString(),
                    s => (CourseRequestStatus)Enum.Parse(typeof(CourseRequestStatus), s)
                );

        }
    }
}
