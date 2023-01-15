using System.ComponentModel.DataAnnotations;

namespace DB_ASP.NET.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "�� ������ �����")]
        public string Login { get; set; }

        [Required(ErrorMessage = "�� ������ ������")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "������ ������ �������")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}