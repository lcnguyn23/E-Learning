using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    public class Media
    {
        public int MediaId { get; set; }
        public string FileName { get; set; }
        public string? FilePath { get; set; }
        public string? FileContent { get; set; }
        public string? FileType { get; set; }
        public long? FileSizeByte { get; set; }
        public int MediaTypeId { get; set; }
        public DateTime? CreatedAt { get; set; }

        // relationships
        public MediaType MediaType { get; set; }
        public IEnumerable<LessonMedia> LessonMedias { get; set; }
    }
}
