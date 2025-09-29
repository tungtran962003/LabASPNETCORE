using Lab3.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Student
    {
        public int Id { get; set; } // Mã sinh viên

        [Required(ErrorMessage = "Chưa nhập họ tên")]
        [Display(Name = "Họ tên")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Họ tên phải có từ {2} đến {1} ký tự.")]
        public string? Name { get; set; } // Họ tên

        [Required(ErrorMessage = "Chưa nhập email")]
        [Display(Name = "Email")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@gmail.com$", ErrorMessage = "Email không hợp lệ (phải có định dạng user@gmail.com).")]
        public string? Email { get; set; } // Email

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Chưa nhập mật khẩu")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có từ {2} đến {1} kí tự")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
                           ErrorMessage = "Mật khẩu phải có tối thiểu 8 ký tự, chứa ít nhất một chữ hoa, một chữ thường, một chữ số và một ký tự đặc biệt.")]
        public string? Password { get; set; } // Password

        [Display(Name = "Ngành học")]
        public Branch? Branch { get; set; } // Ngành học

        [Display(Name = "Giới tính")]
        [Required(ErrorMessage = "Chưa chọn giới tính")]
        public Gender? Gender { get; set; } // Giới tính

        [Display(Name = "Hệ đào tạo")]
        public bool IsRegular { get; set; } // Hệ: true - chính quy, false - phi cq

        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Chưa nhập địa chỉ")]
        [DataType(DataType.MultilineText)]
        public string? Address { get; set; } // Địa chỉ

        [Display(Name = "Ngày sinh")]
        [Required(ErrorMessage = "Chưa chọn ngày tháng")]
        [DataType(DataType.Date, ErrorMessage = "Date of birth is in wrong format")]
        public DateTime? DateOfBirth { get; set; } // Ngày sinh

        [Display(Name = "Điểm")]
        [Required(ErrorMessage = "Chưa nhập điểm")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ {1} đến {2}")]
        public double? Score { get; set; }
    }
}
