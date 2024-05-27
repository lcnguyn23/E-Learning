using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELearning.Data.Interfaces;
using ELearning.DomainModels.EnrollmentManagement;
using ELearning.DomainModels.User;

namespace ELearning.DomainModels
{
    public enum CourseStatus
    {
        PUBLISH = 1,
        UNPUBLISH = 2,
        PENDING_APPROVAL = 3,
    }

    
    public class Course : ISoftDelete
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string? ShortDescription { get; set; }
        public string? Description { get; set; }
        public int InstructorId { get; set; }
        public int TopicId { get; set; }
        public int LevelId { get; set; }
        public string? Duration { get; set; }
        public string? CourseImage { get; set; }
        public CourseStatus Status { get; set; }
        public decimal Price { get; set; }
        public bool IsFree { get; set; }
        public decimal? SalePrice { get; set; }
        public DateTime? SaleStart { get; set; }
        public DateTime? SaleEnd { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }


        // relationships
        public ApplicationUser Instructor { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
        public Topic Topic { get; set; }
        public Level Level { get; set; }
        public IEnumerable<FavoriteCourse> FavoriteCourses { get; set; }
        public IEnumerable<Section> Sections { get; set; }
        public IEnumerable<StudentProgress> StudentProgresses { get; set; }
        public CourseRequest CourseRequests { get; set; }
        public IEnumerable<CourseRating> CourseRatings { get; set; }

    }
}
