using ELearning.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Configurations
{
    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            // key
            builder
                .ToTable("Notifications")
                .HasKey(m => m.NotificationId);

            // properties
            builder
                .Property(fc => fc.CreatedAt)
                .HasColumnType("datetime2");

            builder
                .Property(c => c.NotificationType)
                .HasConversion(
                    s => s.ToString(),
                    s => (NotificationTypes)Enum.Parse(typeof(NotificationTypes), s)
                );
        }
    }
}
