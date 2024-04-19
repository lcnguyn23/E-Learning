using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        // relationships
        public IEnumerable<UserRole> UserRoles { get; set; }
        
    }
}
