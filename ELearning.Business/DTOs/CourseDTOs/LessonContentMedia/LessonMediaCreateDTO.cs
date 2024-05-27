using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.CoursesDTOs.LessonContentMedia
{
    public class LessonMediaCreateDTO
    {
        public int LessonId { get; set; }
        public string? MediaName { get; set; }
        public string? MediaPath { get; set; }
        public string? MediaContent { get; set; }
        public string? MediaUrl { get; set; }
        public MediaType? MediaType { get; set; } 
        public long? FileSize { get; set; }
    }
}
