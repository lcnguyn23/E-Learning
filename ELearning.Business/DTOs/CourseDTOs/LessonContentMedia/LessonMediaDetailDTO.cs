using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.CoursesDTOs.LessonContentMedia
{
    public class LessonMediaDetailDTO
    {
        public int LessonMediaId { get; set; }
        public int LessonId { get; set; }
        public string MediaName { get; set; }
        public string? MediaPath { get; set; }
        public string? MediaUrl { get; set; }
        public string? MediaContent { get; set; } // for embed code
        public MediaType? MediaType { get; set; } // mp4, url, embed (code)
        public long? FizeSize { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
