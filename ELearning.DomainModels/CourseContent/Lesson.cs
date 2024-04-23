using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.DomainModels;

namespace ELearning.DomainModels
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public int SectionId { get; set; }
        public string Title { get; set; }
        public int Order {  get; set; }
        public int LessonTypeId { get; set; }
        public DateTime? CreatedAt { get; set; }

        // relationships
        public Section Section { get; set; }
        public LessonType LessonType { get; set; }
        public IEnumerable<LessonMedia> LessonMedias { get; set; }
        public LessonContent LessonContent { get; set; }
        public IEnumerable<LessonReport> LessonReports { get; set; }
        public Discussion Discussion { get; set; }
        public IEnumerable<StudentProgress> StudentProgresses { get; set; }
        public IEnumerable<StudentLesson> StudentLessons { get; set; }

    }
}
