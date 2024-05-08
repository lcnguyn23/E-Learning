using ELearning.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class Question : ISoftDelete
    {
        public int QuestionId { get; set; }
        public int QuizId { get; set; }
        public int QuestionTypeId { get; set; }
        public int Point { get; set; }
        public int? QuestionOrder { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }

        // relationships
        public Quiz Quiz { get; set; }
        public QuestionType QuestionType { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
        public IEnumerable<QuestionAttempt> QuestionAttempts { get; set; }

    }
}
