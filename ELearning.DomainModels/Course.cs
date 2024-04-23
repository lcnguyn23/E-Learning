using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DomainModels
{
    [Table("Courses")]
    public class Course
    {
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? Description { get; set; }
        public int InstructorId { get; set; }
        public int TopicId { get; set; }
        public int LevelId { get; set; }
        public string? Duration { get; set; }
        public string? CourseImage { get; set; }
        public int Status { get; set; }
        public decimal? Price { get; set; }
        public bool IsFree { get; set; }
        public decimal? SalePrice { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? SaleStart { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? SaleEnd { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;


        // relationships
        public User Instructor { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
        public Topic Topic { get; set; }
        public Level Level { get; set; }
        public IEnumerable<FavoriteCourse> FavoriteCourses { get; set; }
        public CourseStatus CourseStatus { get; set; }
        public IEnumerable<Section> Sections { get; set; }
        public IEnumerable<StudentProgress> StudentProgresses { get; set; }
        public CourseRequest CourseRequests { get; set; }
        public IEnumerable<CourseRating> CourseRatings { get; set; }

    }
}
