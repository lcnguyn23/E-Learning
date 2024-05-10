namespace ELearning.Web.Models
{
    public class LessonMediaViewModel
    {
        public int LessonMediaId { get; set; }
        public int LessonId { get; set; }
        public string FileName { get; set; }
        public string? FilePath { get; set; }
        public string? FileContent { get; set; }
        public string? FileType { get; set; }
        public long? FileSizeByte { get; set; }
    }
}
