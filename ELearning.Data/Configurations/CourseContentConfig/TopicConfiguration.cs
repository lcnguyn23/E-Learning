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
    public class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            // key
            builder
                .ToTable("Topics")
                .HasKey(t => t.TopicId);

            // properties
            builder
                .Property(t => t.TopicName)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(t => t.TopicDescription)
                .HasMaxLength(200);

            builder
                .Property(t => t.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);

        }
    }
}
