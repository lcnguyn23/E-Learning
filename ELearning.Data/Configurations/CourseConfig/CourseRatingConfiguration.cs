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
    public class CourseRatingConfiguration : IEntityTypeConfiguration<CourseRating>
    {
        public void Configure(EntityTypeBuilder<CourseRating> builder)
        {
            // key
            builder
                .ToTable("CourseRatings")
                .HasKey(cr => new { cr.StudentId, cr.CourseId });

            // properties
            builder
                .Property(c => c.Rating)
                .HasDefaultValue(0);

            builder
                .Property(c => c.Comment)
                .HasMaxLength(255);

            builder
                .Property(c => c.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);

            // relationships configuration
            builder
                .HasOne(u => u.Student)
                .WithMany(c => c.CourseRatings)
                .HasForeignKey(u => u.StudentId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
