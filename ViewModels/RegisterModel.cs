using System.ComponentModel.DataAnnotations;

namespace DB_ASP.NET.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не указан логин")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}