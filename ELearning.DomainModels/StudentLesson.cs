using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class StudentLesson
    {
        public int StudentId { get; set; }
        public int LessonId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CompletedAt { get; set; }

        // relationships
        public User Student { get; set; }
        public Lesson Lesson { get; set; }
    }
}
