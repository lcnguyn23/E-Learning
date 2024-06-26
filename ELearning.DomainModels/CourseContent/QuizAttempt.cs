﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.Data.Interfaces;
using ELearning.DomainModels;
using ELearning.DomainModels.User;

namespace ELearning.DomainModels
{
    public enum QuizAttemptStatus
    {
        NOT_STARTED,
        IN_PROGRESS,
        COMPLETED
    }
    public class QuizAttempt : ISoftDelete
    {
        public int QuizAttemptId { get; set; }
        public int StudentId { get; set; }
        public int QuizId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Score { get; set; }
        public QuizAttemptStatus Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }

        // relationships
        public ApplicationUser Student { get; set; }
        public Quiz Quiz { get; set; }
        public IEnumerable<QuestionAttempt> QuestionAttempts { get; set; }
    }
}
