namespace ELearning.Web.Models
{
    public class LessonListViewModel
    {
        public int LessonId { get; set; }
        public int SectionId { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public LessonContentViewModel lessonContentViewModel { get; set; }
        public LessonMediaViewModel lessonMediaViewModel { get; set; }
    }
}
