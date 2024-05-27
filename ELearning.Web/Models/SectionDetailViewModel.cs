namespace ELearning.Web.Models
{
    public class SectionDetailViewModel
    {
        public int SectionId { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int SectionOrder { get; set; }
        public IEnumerable<LessonListViewModel> Lessons { get; set; }
    }
}
