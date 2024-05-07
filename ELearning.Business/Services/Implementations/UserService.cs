using ELearning.Business.Services.Interfaces;
using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels.User;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.Business.Utility;

namespace ELearning.Business.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger<UserService> _logger;

        public UserService(IUserRepository userRepository, ILogger<UserService> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        public async Task<Status> CreateUserAsync(ApplicationUser newUser)
        {
            try
            {
                var result = await _userRepository.CreateAsync(newUser);
                if (result == 0)
                {
                    throw new Exception("Tạo người dùng thất bại");
                }
                return Status.Success;
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error: {e.Message}");
                throw;
            }
        }

        public async Task<Status> DeleteUserAsync(ApplicationUser deleteUser)
        {
            try
            {
                var result = await _userRepository.DeleteAsync(deleteUser);
                if (result == 0)
                {
                    throw new Exception("Xóa người dùng thất bại");
                }
                return Status.Success;
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error: {e.Message}");
                throw;
            }
        }

        public async Task<List<ApplicationUser>> GetAllUserAsync()
        {
            try
            {
                var users = await _userRepository.GetAllAsync();
                if (users is null)
                {
                    throw new Exception("Không có người dùng nào!");
                }
                return users;
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error: {e.Message}");
                throw;
            }
        }

        public async Task<ApplicationUser> GetUserByEmailAsync(string email)
        {
            try
            {
                var user = await _userRepository.GetUserByEmailAsync(email);
                if (user is null)
                {
                    throw new Exception("Không có người dùng nào!");
                }
                return user;
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error: {e.Message}");
                throw;
            }
        }

        public async Task<ApplicationUser> GetUserByIdAsync(int id)
        {
            try
            {
                var user = await _userRepository.GetByIdAnsync(id);
                if (user is null)
                {
                    throw new Exception("Không có người dùng nào!");
                }
                return user;
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error: {e.Message}");
                throw;
            }
        }

        public async Task<Status> UpdateUserAsync(ApplicationUser data)
        {
            try
            {
                var result = await _userRepository.CreateAsync(data);
                if (result == 0)
                {
                    throw new Exception("Cập nhật người dùng thất bại");
                }
                return Status.Success;
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error: {e.Message}");
                throw;
            }
        }
    }
}
