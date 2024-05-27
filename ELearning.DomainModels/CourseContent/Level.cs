using ELearning.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class Level : ISoftDelete
    {
        public int LevelId { get; set; }
        public string LevelName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }


        // relationships
        public IEnumerable<Course> Courses { get; set; }
    }
}
