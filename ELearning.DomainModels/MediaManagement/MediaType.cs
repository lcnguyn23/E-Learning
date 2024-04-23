using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class MediaType
    {
        public int MediaTypeId { get; set; }
        public string TypeName { get; set; }
        public DateTime? CreatedAt { get; set; }

        // relationships
        public IEnumerable<Media> Medias { get; set; }
    }
}
