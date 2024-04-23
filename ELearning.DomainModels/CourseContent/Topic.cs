using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string TopicName { get; set; }
        public string? TopicDescription { get; set; }
        public DateTime? CreatedAt { get; set; }

        // relationships
        public IEnumerable<Course> Courses { get; set; }
    }
}
