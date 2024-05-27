using ELearning.DomainModels.User;
using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.CourseRatingDTOs
{
    public class CourseRatingListDTO
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int StudentId { get; set; }
        public int StudentName { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
    }
}
