﻿using Microsoft.EntityFrameworkCore;

namespace DB_ASP.NET.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options) 
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User 
                { 
                    Id = 1, 
                    Login = "admin", 
                    PasswordHash = User.HashPassword("qwerty"), 
                    Role = Role.Admin 
                },
                new User
                {
                    Id = 2,
                    Login = "mod",
                    PasswordHash = User.HashPassword("qwerty"),
                    Role = Role.Moderator
                },
                new User
                {
                    Id = 3,
                    Login = "user",
                    PasswordHash = User.HashPassword("qwerty"),
                    Role = Role.User
                }
            );
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "qwe",
                    ReleaseDate = new(2022, 11, 23),
                    Genre = "ewq",
                    Price = 300
                }
            );
        }
    }
}
