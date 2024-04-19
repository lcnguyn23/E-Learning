using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public int ModuleId { get; set; }
        public string Title { get; set; }
        public int Order {  get; set; }
        public int LessonTypeId { get; set; }
        public DateTime CreatedAt { get; set; }

        // relationships
        public Module Module { get; set; }
        public LessonType LessonType { get; set; }
    }
}
