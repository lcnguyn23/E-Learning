namespace ELearning.Web.Models
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? IsInstructor { get; set; }
    }
}
