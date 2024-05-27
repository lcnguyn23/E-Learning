using System.ComponentModel.DataAnnotations;

namespace ELearning.Web.Models
{
    public class SectionCreateViewModel
    {
        public int SectionId { get; set; }
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Hãy nhập tên cho chương.")]
        [StringLength(100, ErrorMessage = "Tên chương không được quá 100 ký tự.")]
        public string Title { get; set; }
        public int SectionOrder { get; set; }
    }
}
