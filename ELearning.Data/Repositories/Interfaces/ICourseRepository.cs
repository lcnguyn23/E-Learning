﻿using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface ICourseRepository : IRepository<Course>
    {
        /// <summary>
        /// Get a record by course name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<Course> GetCourseByNameAsync(string name);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="instructorId"></param>
        /// <returns></returns>
        Task<List<Course>> GetAllCouresByInstructorIdAsync(int instructorId);

    }
}
