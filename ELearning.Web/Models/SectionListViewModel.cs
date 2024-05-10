namespace ELearning.Web.Models
{
    public class SectionListViewModel
    {
        public int SectionId { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int SectionOrder { get; set; }
        public IEnumerable<LessonListViewModel> Lessons { get; set; }
    }
}
