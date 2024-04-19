using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class QuestionType
    {
        public int QuestionTypeId { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        // relationships
        public IEnumerable<Question> Questions { get; set; }
    }
}
