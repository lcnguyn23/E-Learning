using ELearning.DomainModels.UserRole;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IRoleRepository : IRepository<IdentityRole>
    {
        Task<IdentityRole?> GetRoleByName(string name);
    }
}
