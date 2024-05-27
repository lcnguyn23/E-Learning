using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.CoursesDTOs.Sections
{
    public class SectionCreateDTO
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
    }
}
