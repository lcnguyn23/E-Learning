using ELearning.DomainModels.UserRole;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        public readonly UserManager<ApplicationUser> _userManager;
        public readonly RoleManager<ApplicationRole> _roleManager;
        public readonly SignInManager<ApplicationUser> _signInManager;

        public UserRepository(
            UserManager<ApplicationUser> userManager, 
            RoleManager<ApplicationRole> roleManager, 
            SignInManager<ApplicationUser> signInManager  )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> CreateUserAsync(ApplicationUser data)
        {
            return await _userManager.CreateAsync(data, data.PasswordHash ?? null!);
        }

        public Task<IdentityResult> DeleteUserAsync(ApplicationUser data)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateUserAsync(ApplicationUser data)
        {
            throw new NotImplementedException();
        }
    }

}
