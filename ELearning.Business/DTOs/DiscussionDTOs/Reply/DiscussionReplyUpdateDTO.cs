using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.DiscussionDTOs.Reply
{
    public class DiscussionReplyUpdateDTO
    {
        public int ReplyId { get; set; }
        public int DiscussionId { get; set; }
        public int UserId { get; set; }
        public string ReplyContent { get; set; }
    }
}
