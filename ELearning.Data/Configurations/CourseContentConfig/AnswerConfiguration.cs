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
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            // key
            builder
                .ToTable("Answers")
                .HasKey(a => a.AnswerId);

            // properties
            builder
                .Property(a => a.Content)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(a => a.CreatedAt)
                .HasColumnType("datetime2");
        }
    }
}
