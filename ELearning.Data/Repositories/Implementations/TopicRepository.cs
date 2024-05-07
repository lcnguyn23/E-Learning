using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Implementations
{
    public class TopicRepository : Repository<Topic>, ITopicRepository
    {
        private readonly ELearningDbContext _context;

        public TopicRepository(ELearningDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
