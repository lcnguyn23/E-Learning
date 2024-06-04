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
using ELearning.Business.DTOs.UserDTOs;
using Microsoft.EntityFrameworkCore;

namespace ELearning.Business.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly ILogger<UserService> _logger;

        
        public UserService(IUserRepository userRepository, IEnrollmentRepository enrollmentRepository, ILogger<UserService> logger)
        {
            _userRepository = userRepository;
            _enrollmentRepository = enrollmentRepository;
            _logger = logger;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deleteUser"></param>
        /// <returns></returns>
        public async Task<Status> DeleteUserAsync(ApplicationUser deleteUser)
        {
            try
            {
                var result = await _userRepository.DeleteAsync(deleteUser);
                if (result == 0)
                {
                    return Status.Fail;
                }
                return Status.Success;
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IQueryable<ApplicationUser>> GetAllUsersAsync()
        {
            try
            {
                var users = await _userRepository.GetAllAsync();
                if (users == null)
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> GetUserByEmailAsync(string email)
        {
            try
            {
                var user = await _userRepository.GetUserByEmailAsync(email);
                if (user == null)
                {
                    throw new Exception($"Không có người dùng nào! 222{email}22");
                }
                return user;
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> GetUserByUserNameAsync(string name)
        {
            try
            {
                var user = await _userRepository.GetUserByEmailAsync(name);
                if (user == null)
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> GetUserByIdAsync(int id)
        {
            try
            {
                var user = await _userRepository.GetByIdAsync(id);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
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

        public async Task<IQueryable<ApplicationUser>> GetInstructorAsync()
        {
            try
            {
                var userlist = await _userRepository.GetAllAsync();
                var listIns = new List<ApplicationUser>();
                foreach (var user in userlist)
                {
                    var userRole = await _userRepository.GetUserRoleAsync(user);
                    if (userRole.Contains("Instructor"))
                    {
                        listIns.Add(user);
                    }
                }
                if (userlist == null)
                {
                    throw new Exception("Không có người dùng nào");
                }
                return listIns.AsQueryable();
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error: {e.Message}");
                throw;
            }
        }
        
    }
}
