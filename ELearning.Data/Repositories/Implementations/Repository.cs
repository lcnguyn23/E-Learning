using ELearning.Data.Interfaces;
using ELearning.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
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

        public async Task<IQueryable<T>> GetAllAsync()
        {
            var query = await _context.Set<T>().ToListAsync();
            return query.AsQueryable();
        }

        public async Task<T> GetByIdAsync(int? id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<int> CreateAsync(T entity)
        {
            _context.Set<T>().AddAsync(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
            
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
