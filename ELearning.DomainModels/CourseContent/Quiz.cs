using ELearning.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class Quiz : ISoftDelete
    {
        public int QuizId { get; set; }
        public int SectionId { get; set; }
        public string Title { get; set;}
        public string? Description { get; set;}
        public int? TimeLimit { get; set; }
        public int? PassingScore { get; set; }
        public int Order {  get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }

        // relationships
        public Section Section { get; set; }
        public IEnumerable<Question> Questions { get; set; }
        public IEnumerable<QuizAttempt> QuizAttempts { get; set; }
    }
}
