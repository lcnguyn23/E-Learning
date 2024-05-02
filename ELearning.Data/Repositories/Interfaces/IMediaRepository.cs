using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IMediaRepository
    {
        Task<List<Media>> GetAllMediasAsync();
        Task<Media> GetMediaByIdAsync(int id);
        Task<int> CreateMediaAsync(Media media);
        Task<int> UpdateMediaAsync(Media media);
        Task<int> DeleteMediaAsync(int id);
    }
}
