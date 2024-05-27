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
    public class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            // key
            builder
                .ToTable("Sections")
                .HasKey(s => s.SectionId);

            // properties
            builder
                .Property(s => s.Title)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(s => s.CreatedAt)
                .HasColumnType("datetime2");
        }
    }
}
