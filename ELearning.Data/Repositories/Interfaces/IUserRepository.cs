using ELearning.DomainModels.User;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<ApplicationUser>
    {
        Task<ApplicationUser?> GetUserByEmailAsync(string email);
        Task<ApplicationUser?> GetUserByUserNameAsync(string name);
        Task<IList<string>> GetUserRoleAsync(ApplicationUser data);
        Task<IdentityResult> AddUserToRoleAsync(ApplicationUser data, string role);
        Task<bool> CheckPasswordAsync(ApplicationUser data, string password);

        
    }
}
