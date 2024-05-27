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
    public class QuestionTypeConfiguration : IEntityTypeConfiguration<QuestionType>
    {
        public void Configure(EntityTypeBuilder<QuestionType> builder)
        {
            // key
            builder
                .ToTable("QuestionTypes")
                .HasKey(q => q.QuestionTypeId);

            // properties
            builder
                .Property(q => q.TypeName)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(q => q.Description)
                .HasMaxLength(100);

            builder
                .Property(q => q.CreatedAt)
                .HasColumnType("datetime2");
        }
    }
}
