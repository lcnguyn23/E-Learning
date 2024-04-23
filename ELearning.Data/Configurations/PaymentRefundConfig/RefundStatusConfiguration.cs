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
    public class RefundStatusConfiguration : IEntityTypeConfiguration<RefundStatus>
    {
        public void Configure(EntityTypeBuilder<RefundStatus> builder)
        {
            // key
            builder
                .ToTable("RefundStatus")
                .HasKey(r => r.RefundStatusId);

            // properties
            builder
                .Property(r => r.Description)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(r => r.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);
        }
    }
}
