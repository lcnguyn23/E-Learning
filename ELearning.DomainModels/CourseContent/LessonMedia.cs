using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class LessonMedia
    {
        public int LessonMediaId { get; set; }
        public int LessonId { get; set; }
        public int MediaId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        // relationships
        public Media Media { get; set; }
        public Lesson Lesson { get; set; }
    }
}
