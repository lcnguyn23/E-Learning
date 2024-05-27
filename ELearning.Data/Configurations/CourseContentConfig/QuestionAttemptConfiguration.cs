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
    public class QuestionAttemptConfiguration : IEntityTypeConfiguration<QuestionAttempt>
    {
        public void Configure(EntityTypeBuilder<QuestionAttempt> builder)
        {
            // key
            builder
                .ToTable("QuestionAttempts")
                .HasKey(q => q.QuestionAttemptId);

            // properties
            builder
                .Property(q => q.Answer)
                .HasMaxLength(255);

            builder
                .Property(q => q.Score)
                .HasDefaultValue(0);

            builder
                .Property(q => q.CreatedAt)
                .HasColumnType("datetime2");
        }
    }
}
