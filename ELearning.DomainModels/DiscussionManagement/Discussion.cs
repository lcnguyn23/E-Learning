using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.DomainModels;
using ELearning.DomainModels.User;

namespace ELearning.DomainModels
{
    public class Discussion
    {
        public int DiscussionId { get; set; }
        public int LessonId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public DateTime? CreatedAt { get; set; }

        // relationships
        public Lesson Lesson { get; set; }
        public IEnumerable<DiscussionReply> DiscussionReplies { get; set; }
        public ApplicationUser User { get; set; }

    }
}
