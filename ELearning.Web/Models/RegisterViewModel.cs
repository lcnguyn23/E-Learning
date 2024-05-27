using System.ComponentModel.DataAnnotations;

namespace ELearning.Web.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Bạn chưa nhập email.")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập họ tên.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập mật khẩu.")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$", ErrorMessage = "Mật khẩu phải dài ít nhất 8 ký tự và chứa ít nhất 1 ký tự in hoa, 1 ký tự in thường và 1 chữ số.")]
        public string Password { get; set; }

        public bool? IsInstructor { get; set; }

        [Required(ErrorMessage = "Hãy nhập lại mật khẩu.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Mật khẩu không đúng.")]
        public string ConfirmPassword { get; set; }
    }
}
