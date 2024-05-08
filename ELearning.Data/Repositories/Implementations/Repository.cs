using ELearning.Data.Interfaces;
using ELearning.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Implementations
{
    
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ELearningDbContext _context;

        public Repository(ELearningDbContext context)
        {
            _context = context;
        }
        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int? id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<int> CreateAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            return entity.GetType().GetProperty("Id")?.GetValue(entity) as int? ?? 0;
        }

        public async Task<int> UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity.GetType().GetProperty("Id")?.GetValue(entity) as int? ?? 0;
        }

        public async Task<int> DeleteAsync(T entity)
        {
            if (entity is ISoftDelete)
            {
                ((ISoftDelete)entity).IsDeleted = true;
            }
            _context.Entry(entity).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }

    }
}
