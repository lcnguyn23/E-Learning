using ELearning.DomainModels;
using ELearning.DomainModels.UserRole;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            // key
            builder
                .ToTable("Roles")
                .HasKey(e => e.Id);

            // properties
            builder
                .Property(e => e.Name)
                .IsRequired();

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
