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
        Task<List<ApplicationUser>> GetAllUsersAsync();
        Task<ApplicationUser> GetUserByIdAsync(int id);
        Task<Status> CreateUserAsync(ApplicationUser user);
        Task<Status> UpdateUserAsync(ApplicationUser user);
        Task<Status> DeleteUserAsync(ApplicationUser user);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<ApplicationUser> GetUserByEmailAsync(string email);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<ApplicationUser> GetUserByUserNameAsync(string name);

        Task<List<ApplicationUser>> GetInstructorAsync();
    }
}
