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
    public class MediaRepository : Repository<Media>, IMediaRepository
    {
        private readonly ELearningDbContext _context;

        public MediaRepository(ELearningDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> CreateMediaTypeAsync(MediaType mediaType)
        {
            _context.Set<MediaType>().Add(mediaType);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteMediaTypeAsync(MediaType mediaType)
        {
            _context.Set<MediaType>().Remove(mediaType);
            return await _context.SaveChangesAsync();
        }

        public async Task<MediaType> GetMediaTypeByIdAsync(int id)
        {
            return await _context.MediaTypes.FindAsync(id);
        }

        public async Task<MediaType> GetMediaTypeByNameAsync(string name)
        {
            return await _context.MediaTypes.FirstOrDefaultAsync(m => m.TypeName.Equals(name));
        }

        public async Task<List<MediaType>> GetMediaTypesAsync()
        {
            return await _context.MediaTypes.ToListAsync();
        }

        public async Task<int> UpdateMediaTypeAsync(MediaType mediaType)
        {
            _context.Entry(mediaType).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }
    }
}
