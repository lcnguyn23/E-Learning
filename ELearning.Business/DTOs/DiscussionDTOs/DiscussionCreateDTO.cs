using ELearning.DomainModels.User;
using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.DiscussionDTOs
{
    public class DiscussionCreateDTO
    {
        public int LessonId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
