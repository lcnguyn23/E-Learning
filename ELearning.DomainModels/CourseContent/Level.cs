using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class Level
    {
        public int LevelId { get; set; }
        public string LevelName { get; set; }
        public DateTime? CreatedAt { get; set; }

        // relationships
        public Course Course { get; set; }
    }
}
