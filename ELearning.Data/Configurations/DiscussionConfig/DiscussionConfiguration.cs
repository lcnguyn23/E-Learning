using ELearning.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Configurations.DiscussionConfig
{
    public class DiscussionConfiguration : IEntityTypeConfiguration<Discussion>
    {
        public void Configure(EntityTypeBuilder<Discussion> builder)
        {
            // key
            builder
                .ToTable("Discussions")
                .HasKey(d => d.DiscussionId);

            // properties
            builder
                .Property(d => d.Content)
                .IsRequired()
                .HasMaxLength(1000);

            builder
                .Property(d => d.CreatedAt)
                .HasColumnType("datetime2");
        }
    }
}
