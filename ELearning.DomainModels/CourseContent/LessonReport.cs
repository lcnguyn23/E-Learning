﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.DomainModels;
using ELearning.DomainModels.UserRole;

namespace ELearning.DomainModels
{
    public class LessonReport
    {
        public int ReportId { get; set; }
        public int LessonId { get; set; }
        public int StudentId { get; set; }
        public string Content { get; set; }
        public string? ProofImage { get; set; }
        public int LessonReportStatusId { get; set; }
        public DateTime? CreatedAt { get; set; }

        // relationships
        public Lesson Lesson { get; set; }
        public ApplicationUser Student { get; set; }
        public LessonReportStatus LessonReportStatus { get; set; }

    }
}