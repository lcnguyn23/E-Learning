using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class QuestionAttempt
    {
        public int QuestionAttemptId { get; set; }
        public int QuizAttemptId { get; set; }
        public int QuestionId { get; set; }
        public string? Answer {  get; set; }
        public int Score { get; set; }
        public DateTime? CreatedAt { get; set; }

        // relationships
        public QuizAttempt QuizAttempt { get; set; }
        public Question Question { get; set; }
    }
}
