using Microsoft.EntityFrameworkCore;
using VibeMock.Models;

namespace VibeMock.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Technology", Description = "Tech-related content" },
                new Category { Id = 2, Name = "Lifestyle", Description = "Lifestyle and wellness" },
                new Category { Id = 3, Name = "Music", Description = "Music and entertainment" }
            );

            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    Title = "Welcome to Vibe",
                    Content = "Experience the future of modern web applications with stunning design and powerful features.",
                    Author = "Admin",
                    CreatedDate = DateTime.Now,
                    ImageUrl = "/images/hero-bg.jpg",
                    CategoryId = 1
                },
                new Post
                {
                    Id = 2,
                    Title = "Modern Design",
                    Content = "Clean, responsive layouts that work beautifully on all devices.",
                    Author = "Admin",
                    CreatedDate = DateTime.Now,
                    ImageUrl = "/images/design.jpg",
                    CategoryId = 2
                },
                new Post
                {
                    Id = 3,
                    Title = "Powerful Features",
                    Content = "Built with .NET Core and Entity Framework for robust performance.",
                    Author = "Admin",
                    CreatedDate = DateTime.Now,
                    ImageUrl = "/images/features.jpg",
                    CategoryId = 1
                }
            );
        }
    }
}
