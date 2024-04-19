﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class QuizAttempt
    {
        public int QuizAttemptId { get; set; }
        public int StudentId { get; set; }
        public int QuizId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }
        public int Score { get; set; }
        public int Status { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        // relationships
        public User Student { get; set; }
        public Quiz Quiz { get; set; }
        public IEnumerable<QuizAttemptStatus> QuizAttemptStatus { get; set; }
        public IEnumerable<QuestionAttempt> QuestionAttempts { get; set; }
    }
}
