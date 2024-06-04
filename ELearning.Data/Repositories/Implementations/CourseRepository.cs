using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ELearning.Data.Repositories.Implementations
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private readonly ELearningDbContext _context;

        public CourseRepository(ELearningDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IQueryable<Course>> SearchAsync(string? searchString, int? topicId, int? levelId, CourseStatus? status, int? rating)
        {
            
            IQueryable<Course> courseQuery = _context.Courses
                                .Where(p => p.IsDeleted == false)
                                .Include(p => p.Topic) // Join với bảng topics
                                .Include(p => p.Level) // Join với bảng levels
                                .Include(p => p.Enrollments) // Join với bảng enrollments
                                .Include(p => p.CourseRatings) // Join với bảng ratings
                                .Include(p => p.Instructor);

            // 
            if (!string.IsNullOrEmpty(searchString))
            {
                courseQuery = courseQuery.Where(p => p.CourseName.Contains(searchString) || p.Instructor.FullName.Contains(searchString));
            }


            // Lọc theo chủ đề
            if (topicId.HasValue && topicId != 0)
            {
                courseQuery = courseQuery.Where(p => p.TopicId == topicId);
            }

            // Lọc theo cấp độ
            if (levelId.HasValue && levelId != 0)
            {
                courseQuery = courseQuery.Where(p => p.LevelId == levelId);
            }

            if (status.HasValue && status != 0)
            {
                courseQuery = courseQuery.Where(p => p.Status == status);
            }

            // Lọc theo số sao tối thiểu trong đánh giá
            if (rating.HasValue && rating != 0)
            {
                courseQuery = courseQuery.Where(p => p.CourseRatings.Average(r => r.Rating) >= rating);
            }

            return courseQuery;
        }

        public async Task<IQueryable<Course>> GetAllCouresByInstructorIdAsync(int instructorId, string? searchString, int? topicId, int? levelId, CourseStatus? status, int? rating)
        {
            IQueryable<Course> courseQuery = _context.Courses
                                .Where(p => p.IsDeleted == false)
                                .Include(p => p.Topic) // Join với bảng topics
                                .Include(p => p.Level) // Join với bảng levels
                                .Include(p => p.Enrollments) // Join với bảng enrollments
                                .Include(p => p.CourseRatings) // Join với bảng ratings
                                .Include(p => p.Instructor)
                                .Where(p => p.InstructorId == instructorId);

            // 
            if (!string.IsNullOrEmpty(searchString))
            {
                courseQuery = courseQuery.Where(p => p.CourseName.Contains(searchString) || p.Instructor.FullName.Contains(searchString));
            }


            // Lọc theo chủ đề
            if (topicId.HasValue && topicId != 0)
            {
                courseQuery = courseQuery.Where(p => p.TopicId == topicId);
            }

            // Lọc theo cấp độ
            if (levelId.HasValue && levelId != 0)
            {
                courseQuery = courseQuery.Where(p => p.LevelId == levelId);
            }

            if (status.HasValue && status != 0)
            {
                courseQuery = courseQuery.Where(p => p.Status == status);
            }

            // Lọc theo số sao tối thiểu trong đánh giá
            if (rating.HasValue && rating != 0)
            {
                courseQuery = courseQuery.Where(p => p.CourseRatings.Average(r => r.Rating) >= rating);
            }

            return courseQuery;
        }

        public async Task<Course> GetCourseByNameAsync(string name)
        {
            var course = await _context.Courses!
                .FirstOrDefaultAsync(c => c.CourseName.Equals(name));
            return course;
        }

    }
}
