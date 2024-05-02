using ELearning.DomainModels.UserRole;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<ApplicationUser>> GetAllUserAsync();
        Task<ApplicationUser?> GetUserByIdAsync(int id);
        Task<ApplicationUser?> GetUserByEmailAsync(string email);
        Task<IdentityResult> CreateUserAsync(ApplicationUser data);
        Task<IdentityResult> UpdateUserAsync(ApplicationUser data);
        Task<IdentityResult> DeleteUserAsync(ApplicationUser data);
        Task<IList<string>> GetUserRoleAsync(ApplicationUser data);
        Task<IdentityResult> AddUserToRoleAsync(ApplicationUser data, string role);
        Task<bool> CheckPasswordAsync(ApplicationUser data, string password);
    }
}
