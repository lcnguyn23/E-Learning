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
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            // key
            builder
                .ToTable("UserRoles")
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            // properties
            builder
                .Property(u => u.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);

        }
    }
}
