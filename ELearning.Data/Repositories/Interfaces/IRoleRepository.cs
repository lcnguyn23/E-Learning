using ELearning.DomainModels.UserRole;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        Task<List<ApplicationRole>> GetAllRoleAsync();
        Task<ApplicationRole?> GetRoleById(int id);
        Task<ApplicationRole?> GetRoleByName(string name);
        Task<IdentityResult> CreateRoleAsync(ApplicationRole role);
        Task<IdentityResult> UpdateRoleAsync(ApplicationRole role);
        Task<IdentityResult> DeleteRoleAsync(ApplicationRole role);
    }
}
