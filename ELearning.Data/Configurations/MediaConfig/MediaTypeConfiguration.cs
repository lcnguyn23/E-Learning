using ELearning.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Configurations.MediaConfig
{
    public class MediaTypeConfiguration : IEntityTypeConfiguration<MediaType>
    {
        public void Configure(EntityTypeBuilder<MediaType> builder)
        {
            // key
            builder
                .ToTable("MediaTypes")
                .HasKey(m => m.MediaTypeId);

            // properties
            builder
                .Property(m => m.TypeName)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(m => m.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);
        }
    }
}
