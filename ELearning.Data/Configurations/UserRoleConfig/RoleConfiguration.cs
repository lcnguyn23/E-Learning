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
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            // key
            builder
                .ToTable("Roles")
                .HasKey(e => e.RoleId);

            // properties
            builder
                .Property(e => e.RoleName)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(e => e.Description)
                .HasMaxLength(255);

            builder
                .Property(e => e.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);
        }
    }
}
