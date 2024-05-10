namespace ELearning.Web.Models
{
    public class CoursePageViewModel
    {
        public CourseListViewModel CourseListViewModel { get; set; }
        // section
        public IEnumerable<SectionListDto> SectionListViewModel { get; set; }
    }
}
