using ELearning.DomainModels.User;
using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.DiscussionDTOs
{
    public class DiscussionUpdateDTO
    {
        public int DiscussionId { get; set; }
        public string Content { get; set; }
    }
}
