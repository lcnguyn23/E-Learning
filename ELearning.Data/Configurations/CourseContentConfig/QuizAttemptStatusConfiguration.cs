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
    public class QuizAttemptStatusConfiguration : IEntityTypeConfiguration<QuizAttemptStatus>
    {
        public void Configure(EntityTypeBuilder<QuizAttemptStatus> builder)
        {
            // key
            builder
                .ToTable("QuizAttemptStatus")
                .HasKey(q => q.QuizAttemptStatusId);

            // properties
            builder
                .Property(q => q.Description)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(q => q.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);

        }
    }
}
