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
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            // key
            builder
                .ToTable("Questions")
                .HasKey(q => q.QuestionId);

            // properties
            builder
                .Property(q => q.Point)
                .IsRequired()
                .HasDefaultValue(0);

            builder
                .Property(q => q.CreatedAt)
                .HasColumnType("datetime2");
        }
    }
}
