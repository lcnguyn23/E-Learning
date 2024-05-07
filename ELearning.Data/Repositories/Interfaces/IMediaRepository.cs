using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IMediaRepository : IRepository<Media>
    {

        // Media type
        Task<List<MediaType>> GetMediaTypesAsync();
        Task<MediaType> GetMediaTypeByIdAsync(int id);
        Task<MediaType> GetMediaTypeByNameAsync(string name);
        Task<int> CreateMediaTypeAsync(MediaType mediaType);
        Task<int> UpdateMediaTypeAsync(MediaType mediaType);
        Task<int> DeleteMediaTypeAsync(MediaType mediaType);
        
    }
}
