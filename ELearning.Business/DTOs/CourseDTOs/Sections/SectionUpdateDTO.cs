using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.CoursesDTOs.Sections
{
    public class SectionUpdateDTO
    {
        public int SectionId { get; set; } 
        public int CourseId { get; set; } 
        public string Title { get; set; }
        public int Order { get; set; }
    }
}
