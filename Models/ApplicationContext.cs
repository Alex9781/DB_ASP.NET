using Microsoft.EntityFrameworkCore;

namespace DB_ASP.NET.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options) 
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { 
                    Id = 1, 
                    Login = "Admin", 
                    PasswordHash = User.HashPassword("qwerty"), 
                    Role = Role.Admin }
                );

        }
    }
}
