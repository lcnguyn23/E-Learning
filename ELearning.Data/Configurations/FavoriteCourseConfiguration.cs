using ELearning.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Configurations
{
    public class FavoriteCourseConfiguration : IEntityTypeConfiguration<FavoriteCourse>
    {
        public void Configure(EntityTypeBuilder<FavoriteCourse> builder)
        {
            // key
            builder
                .ToTable("FavoriteCourses")
                .HasKey(fc => new { fc.UserId, fc.CourseId });

            // properties
            builder
                .Property(fc => fc.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);

        }
    }
}
