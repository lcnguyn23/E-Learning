﻿using ELearning.Data.Repositories.Implementations;
using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories
{
    public class UserRepository : Repository<ApplicationUser>, IUserRepository
    {
        private readonly ELearningDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UserRepository(
            ELearningDbContext context,
            UserManager<ApplicationUser> userManager, 
            RoleManager<IdentityRole> roleManager,
            SignInManager<ApplicationUser> signInManager  ) : base(context)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> AddUserToRoleAsync(ApplicationUser data, string role)
        {
            return await _userManager.AddToRoleAsync(data, role);
        }

        public async Task<bool> CheckPasswordAsync(ApplicationUser data, string password)
        {
            return await _userManager.CheckPasswordAsync(data, password);
        }

        public async Task<ApplicationUser?> GetUserByEmailAsync(string email)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Email == email);
            return user;
        }

        public async Task<IList<string>> GetUserRoleAsync(ApplicationUser data)
        {
            return await _userManager.GetRolesAsync(data);
        }


    }

}