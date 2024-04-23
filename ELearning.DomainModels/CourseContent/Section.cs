using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class Section
    {
        public int SectionId { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int SectionOrder {  get; set; }
        public DateTime? CreatedAt { get; set; }

        // relationships
        public Course Course { get; set;}
        public IEnumerable<Lesson> Lessons { get; set; }
        public IEnumerable<Quiz> Quizzes { get; set; }
        public IEnumerable<StudentProgress> StudentProgresses { get; set; }
    }
}
