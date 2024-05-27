using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Implementations
{
    public class LevelRepository : Repository<Level>, ILevelRepository
    {
        private readonly ELearningDbContext _context;

        public LevelRepository(ELearningDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Level> GetLevelByNameAsync(string levelName)
        {
            return await _context.Set<Level>().FirstOrDefaultAsync(p => p.LevelName == levelName);
        }
    }
}
