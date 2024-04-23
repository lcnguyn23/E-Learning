﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class QuizAttemptStatus
    {
        public int QuizAttemptStatusId { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        
        // relationships
        public IEnumerable<QuizAttempt> QuizAttempts { get; set; }
    }
}
