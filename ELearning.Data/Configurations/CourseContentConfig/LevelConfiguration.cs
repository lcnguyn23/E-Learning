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
    public class LevelConfiguration : IEntityTypeConfiguration<Level>
    {
        public void Configure(EntityTypeBuilder<Level> builder)
        {
            // key
            builder
                .ToTable("Levels")
                .HasKey(l => l.LevelId);

            // properties
            builder
                .Property(l => l.LevelName)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(l => l.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);
        }
    }
}
