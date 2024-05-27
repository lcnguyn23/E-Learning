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
    public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            // key
            builder
                .ToTable("Quizzes")
                .HasKey(q => q.QuizId);

            // properties
            builder
                .Property(q => q.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder
                .Property(q => q.Description)
                .HasMaxLength(400);

            builder
                .Property(q => q.TimeLimit)
                .HasDefaultValue(0);

            builder
                .Property(q => q.PassingScore) 
                .HasDefaultValue(0);

            builder
                .Property(q => q.Order)
                .HasDefaultValue(0);

            builder
                .Property(q => q.CreatedAt)
                .HasColumnType("datetime2");
        }
    }
}
