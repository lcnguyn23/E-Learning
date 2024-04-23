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
    public class PaymentStatusConfiguration : IEntityTypeConfiguration<PaymentStatus>
    {
        public void Configure(EntityTypeBuilder<PaymentStatus> builder)
        {
            // key
            builder
                .ToTable("PaymentStatus")
                .HasKey(p => p.PaymentStatusId);

            // properties
            builder
                .Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);
        }
    }
}
