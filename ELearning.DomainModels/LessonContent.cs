using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class LessonContent
    {
        public int LessonContentId { get; set; }
        public int LessonId { get; set; }
        public string Description { get; set; }
        public string Content {  get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        // relationships
        public Lesson Lesson { get; set; }
    }
}
