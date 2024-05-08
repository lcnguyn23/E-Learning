﻿using ELearning.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class LessonMedia : ISoftDelete
    {
        public int LessonMediaId { get; set; }
        public int LessonId { get; set; }
        public string FileName { get; set; }
        public string? FilePath { get; set; }
        public string? FileContent { get; set; }
        public string? FileType { get; set; }
        public long? FileSizeByte { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }

        // relationships
        public Lesson Lesson { get; set; }
    }
}
