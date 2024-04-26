using ELearning.Data.Repositories;
using ELearning.DomainModels.UserRole;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<bool> CreateUserAsync(ApplicationUser newUser)
        {
            var result = await _userRepository.CreateUserAsync(newUser);
            if (!result.Succeeded)
            {
                throw new Exception($"Tạo người dùng thất bại: {result.Errors.First().Description}");
            }
            return result.Succeeded;
        }

        public Task<bool> DeleteUserAsync(ApplicationUser deleteUser)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUserAsync(ApplicationUser data, List<IFormFile>? avatar)
        {
            throw new NotImplementedException();
        }
    }
}
