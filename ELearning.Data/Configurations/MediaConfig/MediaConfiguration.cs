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
    public class MediaConfiguration : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            // key
            builder
                .ToTable("Media")
                .HasKey(m => m.MediaId);

            // properties
            builder
                .Property(m => m.FileName)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(m => m.FilePath)
                .HasMaxLength(2000);
            
            builder
                .Property(m => m.FileContent)
                .HasMaxLength(2000);

            builder
                .Property(m => m.FileType)
                .HasMaxLength(100);

            builder
                .Property(m => m.FileSizeByte)
                .HasColumnType("bigint");

            builder
                .Property(m => m.CreatedAt)
                .HasColumnType("datetime2")
                .HasDefaultValue(DateTime.Now);
        }
    }
}
