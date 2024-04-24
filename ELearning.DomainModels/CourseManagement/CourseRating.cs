using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.DomainModels;
using ELearning.DomainModels.UserRole;

namespace ELearning.DomainModels
{
    public class CourseRating
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime? CreatedAt { get; set; }

        // relationships
        public Course Course { get; set; }
        public ApplicationUser Student { get; set; }
    }
}
