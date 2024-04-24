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
    public class StudentLesson
    {
        public int StudentId { get; set; }
        public int LessonId { get; set; }
        public DateTime? CompletedAt { get; set; }

        // relationships
        public ApplicationUser Student { get; set; }
        public Lesson Lesson { get; set; }
    }
}
