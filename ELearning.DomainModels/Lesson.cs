using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        // relationships
        public Module Module { get; set; }
        public LessonType LessonType { get; set; }
        public IEnumerable<LessonMedia> LessonMedias { get; set; }

    }
}
