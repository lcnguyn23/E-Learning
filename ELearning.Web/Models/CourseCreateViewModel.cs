using ELearning.DomainModels;
using System.ComponentModel.DataAnnotations;

namespace ELearning.Web.Models
{
    public class CourseCreateViewModel
    {
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên khóa học")]
        public string CourseName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mô tả ngắn")]
        public string ShortDescription { get; set; }
        public string? Description { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn chủ đề")]
        public int TopicId { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn cấp độ")]
        public int LevelId { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thời lượng")]
        public string Duration { get; set; }
        public string? CourseImage { get; set; }
        public CourseStatus Status { get; set; }
        public decimal Price { get; set; }
        public bool IsFree { get; set; }
        public decimal? SalePrice { get; set; }
        public DateTime? SaleStart { get; set; }
        public DateTime? SaleEnd { get; set; }
        public DateTime? CreateAt { get; set; }
    }
}
