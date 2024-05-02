using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IDiscussionRepository
    {
        Task<List<Discussion>> GetAllDiscussionsAsync();
        Task<int> CreateDiscussionAsync(Discussion data);
        Task<int> UpdateDiscussionAsync(Discussion data);
        Task<int> DeleteDiscussionAsync(int id);

        Task<List<DiscussionReply>> GellAllDiscussionReplies();
        Task<int> CreateDiscussionReplyAsync(DiscussionReply data);
        Task<int> UpdateDiscussionReplyAsync(DiscussionReply data);
        Task<int> DeleteDiscussionReplyAsync(int id);
    }
}
