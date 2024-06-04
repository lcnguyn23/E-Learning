using ELearning.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public enum MediaType
    {
        Url,
        Mp4,
        Embed,
        Mp3,
        Image
    }

    public class LessonMedia : ISoftDelete
    {
        public int LessonMediaId { get; set; }
        public int LessonId { get; set; }
        public string? MediaName { get; set; }
        public string? MediaPath { get; set; }
        public string? MediaUrl { get; set; }
        public string? MediaContent { get; set; }
        public MediaType? MediaType { get; set; }
        public long? FileSizeByte { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }

        // relationships
        public Lesson Lesson { get; set; }
    }
}
