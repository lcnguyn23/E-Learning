using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.TopicDTOs
{
    public class TopicListDTO
    {
        public int TopicId { get; set; }
        public string TopicName { get; set; }
        public string? TopicDescription { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
    }
}
