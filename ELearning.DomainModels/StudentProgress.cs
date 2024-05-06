using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.DomainModels;
using ELearning.DomainModels.User;

namespace ELearning.DomainModels
{
    public class StudentProgress
    {
        public int ProgressId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int SectionId { get; set; }
        public int LessonId { get; set; }
        public DateTime? CreatedAt { get; set; }

        // relationships
        public ApplicationUser Student { get; set; }
        public Course Course { get; set; }
        public Section Section { get; set; }
        public Lesson Lesson { get; set; }

    }
}
