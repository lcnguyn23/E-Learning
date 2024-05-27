using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.CourseRatingDTOs
{
    public class CourseRatingUpdateDTO
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
    }
}
