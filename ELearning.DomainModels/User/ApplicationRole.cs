using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels.UserRole
{
    public class ApplicationRole : IdentityRole<int>
    {
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }

        // relationships
        public IEnumerable<ApplicationUserRole> UserRoles { get; set; }
        //public ICollection<IdentityRoleClaim<int>> RoleClaims { get; set; }
    }
}
