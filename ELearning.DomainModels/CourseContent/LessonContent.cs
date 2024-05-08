using ELearning.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class LessonContent : ISoftDelete
    {
        public int LessonContentId { get; set; }
        public int LessonId { get; set; }
        public string? Description { get; set; }
        public string? Content {  get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }

        // relationships
        public Lesson Lesson { get; set; }
    }
}
