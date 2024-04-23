using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.DomainModels;

namespace ELearning.Data.Configurations.UserConfig
{
    public class UserStatusConfiguration : IEntityTypeConfiguration<UserStatus>
    {
        public void Configure(EntityTypeBuilder<UserStatus> builder)
        {
            // key
            builder
                .ToTable("UserStatus")
                .HasKey(u => u.UserStatusId);

            // properties
            builder
                .Property(u => u.Description)
                .HasMaxLength(255);

            builder
                .Property(u => u.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);
        }
    }
}
