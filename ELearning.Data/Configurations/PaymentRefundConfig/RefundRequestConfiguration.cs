using ELearning.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Configurations.PaymentRefundConfig
{
    public class RefundRequestConfiguration : IEntityTypeConfiguration<RefundRequest>
    {
        public void Configure(EntityTypeBuilder<RefundRequest> builder)
        {
            // key
            builder
                .ToTable("RefundRequests")
                .HasKey(r => r.RefundRequestId);

            // properties
            builder
                .Property(r => r.RefundAmount)
                .HasColumnType("decimal(18,2)");

            builder
                .Property(r => r.RefundReason)
                .HasMaxLength(255);

            builder
                .Property(r => r.Note)
                .HasMaxLength(255);

            builder
                .Property(r => r.ApprovalAt)
                .HasColumnType("datetime2");

            builder
                .Property(r => r.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);

            // Status
            builder
                .Property(c => c.Status)
                .HasConversion(
                    s => s.ToString(),
                    s => (RefundStatus)Enum.Parse(typeof(RefundStatus), s)
                );
        }
    }
}
