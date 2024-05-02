using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels.UserRole;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<ApplicationUser>> GetAllUserAsync()
        {
            var users = await _userManager!.Users.ToListAsync();
            return users;
        }

        public async Task<ApplicationUser?> GetUserByIdAsync(int id)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }

        public async Task<ApplicationUser?> GetUserByEmailAsync(string email)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Email == email);
            return user;
        }


        public async Task<IdentityResult> CreateUserAsync(ApplicationUser data)
        {
            return await _userManager.CreateAsync(data);
        }

        public async Task<IdentityResult> UpdateUserAsync(ApplicationUser data)
        {
            return await _userManager.UpdateAsync(data);
        }

        public async Task<IdentityResult> DeleteUserAsync(ApplicationUser data)
        {
            return await _userManager.DeleteAsync(data);
        }


        public async Task<bool> CheckPasswordAsync(ApplicationUser data, string password)
        {
            return await _userManager.CheckPasswordAsync(data, password);   
        }

        public async Task<IList<string>> GetUserRoleAsync(ApplicationUser data)
        {
            return await _userManager.GetRolesAsync(data);
        }

        public async Task<IdentityResult> AddUserToRoleAsync(ApplicationUser data, string role)
        {
            return await _userManager.AddToRoleAsync(data, role);
        }

    }

}
