using ELearning.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class QuestionType : ISoftDelete
    {
        public int QuestionTypeId { get; set; }
        public string TypeName { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }

        // relationships
        public IEnumerable<Question> Questions { get; set; }
    }
}
