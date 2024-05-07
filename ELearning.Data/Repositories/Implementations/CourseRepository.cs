﻿using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Implementations
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private readonly ELearningDbContext _context;

        public CourseRepository(ELearningDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Course> GetCourseByNameAsync(string name)
        {
            var course = await _context.Courses!
                .FirstOrDefaultAsync(c => c.CourseName.Equals(name));
            return course;
        }

    }
}