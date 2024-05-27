using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.CoursesDTOs.LessonContentMedia
{
    public class LessonContentCreateDTO
    {
        public int LessonId { get; set; } 
        public string Description { get; set; }
        public string Content { get; set; }
    }
}
