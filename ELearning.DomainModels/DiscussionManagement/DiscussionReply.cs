using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.Data.Interfaces;
using ELearning.DomainModels;
using ELearning.DomainModels.User;

namespace ELearning.DomainModels
{
    public class DiscussionReply : ISoftDelete
    {
        public int ReplyId { get; set; }
        public int DiscussionId { get; set; }
        public int UserId { get; set; }
        public string ReplyContent { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }

        // relationships
        public Discussion Discussion { get; set; }
        public ApplicationUser User { get; set; }
    }
}
