using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.DomainModels;

namespace ELearning.DomainModels
{
    public class DiscussionReply
    {
        public int ReplyId { get; set; }
        public int DiscussionId { get; set; }
        public int UserId { get; set; }
        public string ReplyContent { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        // relationships
        public Discussion Discussion { get; set; }
        public User User { get; set; }
    }
}
