﻿using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface ISectionRepository : IRepository<Section>
    {
        Task<List<Section>> GetAllSectionsByCourseIdAsync(int courseId);

        Task<Section> GetNextSectionAsync(int courseId, int sectionId);
    }
}
