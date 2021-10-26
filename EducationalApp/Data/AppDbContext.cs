using EducationalApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EducationalApp.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Blog>().Property(u => u.isCorrect).HasDefaultValue(false);
            builder.Entity<IdentityUser>().HasData(
            new IdentityUser
            {
                Id = "65388652-6daa-4fe5-9571-deec9515067f",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@mail.ru",
                NormalizedEmail = "ADMIN@MAIL.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "admin123"),
                SecurityStamp = string.Empty
            },
             new IdentityUser
             {
                 Id = "88004402-8e7c-4a33-bd0c-277c3b73bb7e",
                 UserName = "moder",
                 NormalizedUserName = "MODER",
                 Email = "moder@mail.ru",
                 NormalizedEmail = "MODER@MAIL.RU",
                 EmailConfirmed = true,
                 PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "moder123"),
                 SecurityStamp = string.Empty
             },
             new IdentityUser
             {
                 Id ="ae0b4b86-c83c-4718-8de4-96b8a3aa8c11",
                 UserName = "alex",
                 NormalizedUserName = "ALEX",
                 Email = "alex@mail.ru",
                 NormalizedEmail = "ALEX@MAIL.RU",
                 EmailConfirmed = true,
                 PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "alex123"),
                 SecurityStamp = string.Empty
             }
            );
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "ba3b6228-b36e-4806-be6b-c6fb40cb3821",
                    Name = "admin",
                    NormalizedName = "ADMIN"
                },
                 new IdentityRole
                 {
                     Id = "d9dd2d53-8b9b-4501-af7c-8c5977fb292c",
                     Name = "moder",
                     NormalizedName = "MODER"
                 }
                );
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "ba3b6228-b36e-4806-be6b-c6fb40cb3821",
                    UserId= "65388652-6daa-4fe5-9571-deec9515067f"
                }, new IdentityUserRole<string>
                {
                    RoleId = "d9dd2d53-8b9b-4501-af7c-8c5977fb292c",
                     UserId= "88004402-8e7c-4a33-bd0c-277c3b73bb7e"
                }
                );
            
        }
    }
}
