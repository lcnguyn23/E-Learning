using ELearning.DomainModels.UserRole;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.Services
{
    public interface IUserService
    {
        Task<bool> CreateUserAsync(ApplicationUser newUser);
        Task<bool> UpdateUserAsync(ApplicationUser data, List<IFormFile>? avatar);
        Task<bool> DeleteUserAsync(ApplicationUser deleteUser);
    }
}
