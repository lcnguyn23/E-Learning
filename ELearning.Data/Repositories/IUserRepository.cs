using ELearning.DomainModels.UserRole;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories
{
    public interface IUserRepository
    {
        Task<IdentityResult> UpdateUserAsync(ApplicationUser data);
        Task<IdentityResult> CreateUserAsync(ApplicationUser data);
        Task<IdentityResult> DeleteUserAsync(ApplicationUser data);
    }
}
