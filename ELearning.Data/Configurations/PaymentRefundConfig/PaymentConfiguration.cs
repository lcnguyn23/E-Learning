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
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            // key
            builder
                .ToTable("Payments")
                .HasKey(p => p.PaymentId);

            // properties
            builder
                .Property(p => p.Amount)
                .HasColumnType("decimal(18,2)");

            builder
                .Property(p => p.CreatedAt)
                .HasColumnType("datetime2");

            // Status
            builder
                .Property(c => c.Status)
                .HasConversion(
                    s => s.ToString(),
                    s => (PaymentStatus)Enum.Parse(typeof(PaymentStatus), s)
                );
        }
    }
}
