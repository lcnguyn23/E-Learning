using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Business.DTOs.CoursesDTOs.CourseDetail
{
    public class CourseDetailDTO
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string TopicName { get; set; } 
        public string LevelName { get; set; } 
        public string Duration { get; set; }
        public string CourseImage { get; set; }
        public CourseStatus Status { get; set; }
        public decimal Price { get; set; }
        public bool IsFree { get; set; }
        public decimal? SalePrice { get; set; }
        public DateTime? SaleStart { get; set; }
        public DateTime? SaleEnd { get; set; }
        public string InstructorName { get; set; } 
        public int EnrolledStudentCount { get; set; }
        public double AverageRating { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
