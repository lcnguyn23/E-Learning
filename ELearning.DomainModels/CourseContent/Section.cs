using ELearning.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class Section : ISoftDelete
    {
        public int SectionId { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int SectionOrder {  get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }

        // relationships
        public Course Course { get; set;}
        public IEnumerable<Lesson> Lessons { get; set; }
        public IEnumerable<StudentProgress> StudentProgresses { get; set; }
    }
}
