using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.LevelDTOs
{
    public class LevelDetailDTO
    {
        public int LevelId { get; set; }
        public string LevelName { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
