using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int QuizId { get; set; }
        public int QuestionTypeId { get; set; }
        public int Point { get; set; }
        public int QuestionOrder { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        // relationships
        public Quiz Quiz { get; set; }
        public QuestionType QuestionType { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
        public IEnumerable<QuizAttempt> QuizAttempts { get; set; }
        public IEnumerable<QuestionAttempt> QuestionAttempts { get; set; }

    }
}
