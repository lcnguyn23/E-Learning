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
    public class DiscussionReplyConfiguration : IEntityTypeConfiguration<DiscussionReply>
    {
        public void Configure(EntityTypeBuilder<DiscussionReply> builder)
        {
            // key
            builder
                .ToTable("DiscussionReplies")
                .HasKey(d => d.ReplyId);

            // properties
            builder
                .Property(d => d.ReplyContent)
                .IsRequired()
                .HasMaxLength(1000);

            builder
                .Property(d => d.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);

            // relationships configuration
            builder
                .HasOne(d => d.Discussion)
                .WithMany(dr => dr.DiscussionReplies)
                .HasForeignKey(d => d.DiscussionId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
