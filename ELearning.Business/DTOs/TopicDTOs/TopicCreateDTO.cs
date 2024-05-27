using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.TopicDTOs
{
    public class TopicCreateDTO
    {
        public string TopicName { get; set; }
        public string? TopicDescription { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
