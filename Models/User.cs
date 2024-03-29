﻿using System.ComponentModel.DataAnnotations;
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
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public Role Role { get; set; }

        public static string HashPassword(string password) => 
            Convert.ToHexString(SHA512.HashData(Encoding.UTF8.GetBytes(password)));
    }
}
