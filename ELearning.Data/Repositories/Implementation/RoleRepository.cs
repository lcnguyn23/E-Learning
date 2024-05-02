using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels.UserRole;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Implementation
{
    public class RoleRepository : IRoleRepository
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        public RoleRepository(RoleManager<ApplicationRole> roleManager) {
            _roleManager = roleManager;
        }

        public async Task<List<ApplicationRole>> GetAllRoleAsync()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return roles;
        }

        public async Task<ApplicationRole?> GetRoleById(int id)
        {
            return await _roleManager.Roles.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<ApplicationRole?> GetRoleByName(string name)
        {
            return await _roleManager.Roles.FirstOrDefaultAsync(r => r.Name == name);
        }

        public async Task<IdentityResult> CreateRoleAsync(ApplicationRole role)
        {
            return await _roleManager.CreateAsync(role);
        }

        public async Task<IdentityResult> UpdateRoleAsync(ApplicationRole role)
        {
            return await _roleManager.UpdateAsync(role);
        }

        public async Task<IdentityResult> DeleteRoleAsync(ApplicationRole role)
        {
            return await _roleManager.DeleteAsync(role);
        }

        
    }
}
