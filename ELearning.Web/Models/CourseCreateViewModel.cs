using ELearning.DomainModels;
using System.ComponentModel.DataAnnotations;

namespace ELearning.Web.Models
{
    public class CourseCreateViewModel
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string ShortDescription { get; set; }
        public string? Description { get; set; }
        public int TopicId { get; set; }
        public int LevelId { get; set; }
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
