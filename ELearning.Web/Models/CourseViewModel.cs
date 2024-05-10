using ELearning.DomainModels;
using ELearning.DomainModels.User;

namespace ELearning.Web.Models
{
    public class CourseViewModel
    {
        public List<Course> Courses { get; set; }
        public List<Level> Levels { get; set; }
        public List<Topic> Topics { get; set; }
    }
}
