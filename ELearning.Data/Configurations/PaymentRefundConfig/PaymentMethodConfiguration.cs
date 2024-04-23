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
    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            // key
            builder
                .ToTable("PaymentMethods")
                .HasKey(p => p.PaymentMethodId);

            // properties
            builder
                .Property(p => p.PaymentMethodName)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);
        }
    }
}
