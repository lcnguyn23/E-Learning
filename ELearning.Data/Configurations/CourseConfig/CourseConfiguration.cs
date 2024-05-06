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
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            // key
            builder
                .ToTable("Courses")
                .HasKey(e => e.CourseId);

            // properties
            builder
                .Property(e => e.CourseName)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(e => e.Description)
                .HasMaxLength(500);

            builder
                .Property(e => e.Duration)
                .HasMaxLength(50);

            builder
                .Property(e => e.CourseImage)
                .HasMaxLength(2000);

            builder
                .Property(e => e.Price)
                .HasColumnType("decimal(18,2)");

            builder
                .Property(e => e.SalePrice)
                .HasColumnType("decimal(18,2)");

            builder
                .Property(e => e.SaleStart)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);

            builder
                .Property(e => e.SaleEnd)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);

            builder
                .Property(e => e.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);

            // relationships configuration
            builder
                .HasMany(u => u.FavoriteCourses)
                .WithOne(fc => fc.Course)
                .HasForeignKey(u => u.CourseId)
                .OnDelete(DeleteBehavior.NoAction);

            // Status
            builder
                .Property(c => c.Status)
                .HasConversion(
                    s => s.ToString(),
                    s => (CourseStatus)Enum.Parse(typeof(CourseStatus), s)
                );
        }
    }
}
