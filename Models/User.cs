using System.Security.Cryptography;
using System.Text;

namespace DB_ASP.NET.Models
{
    public enum Role
    {
        Admin,
        Moderator,
        User
    }

    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public Role Role { get; set; }

        public static string HashPassword(string password) => 
            Convert.ToHexString(SHA512.HashData(Encoding.UTF8.GetBytes(password)));
    }
}
