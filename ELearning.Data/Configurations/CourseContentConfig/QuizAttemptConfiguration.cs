﻿using ELearning.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Configurations.CourseContentConfig
{
    public class QuizAttemptConfiguration : IEntityTypeConfiguration<QuizAttempt>
    {
        public void Configure(EntityTypeBuilder<QuizAttempt> builder)
        {
            // key
            builder
                .ToTable("QuizAttempts")
                .HasKey(q => q.QuizAttemptId);

            // properties
            builder
                .Property(q => q.StartDate)
                .HasColumnType("datetime2");

            builder
                .Property(q => q.EndDate)
                .HasColumnType("datetime2");

            builder
                .Property(q => q.Score)
                .HasDefaultValue(0);

            builder
                .Property(q => q.CreatedAt)
                .HasColumnType("datetime2");

            // relationships configuration
            builder
                .HasMany(q => q.QuestionAttempts)
                .WithOne(q => q.QuizAttempt)
                .HasForeignKey(q => q.QuizAttemptId)
                .OnDelete(DeleteBehavior.NoAction);

            // Status
            builder
                .Property(c => c.Status)
                .HasConversion(
                    s => s.ToString(),
                    s => (QuizAttemptStatus)Enum.Parse(typeof(QuizAttemptStatus), s)
                );

        }
    }
}
