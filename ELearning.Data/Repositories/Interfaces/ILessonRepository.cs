using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface ILessonRepository :    IRepository<Lesson>, 
                                            IRepository<LessonContent>, 
                                            IRepository<LessonMedia>,
                                            IRepository<LessonReport>
    {
        

    }
}
