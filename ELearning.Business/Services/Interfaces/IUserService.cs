using ELearning.Business.Utility;
using ELearning.DomainModels.User;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<ApplicationUser>> GetAllUserAsync();
        Task<ApplicationUser> GetUserByIdAsync(int id);
        Task<ApplicationUser> GetUserByEmailAsync(string email);
        Task<Status> CreateUserAsync(ApplicationUser user);
        Task<Status> UpdateUserAsync(ApplicationUser user);
        Task<Status> DeleteUserAsync(ApplicationUser user);
    }
}
