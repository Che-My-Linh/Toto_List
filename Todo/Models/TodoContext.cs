using Microsoft.EntityFrameworkCore;

namespace Todo.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<Todo> Todos { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Status> Statuss { get; set; } = null!;

        // Seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "work", CategoryName = "Work" },
                new Category { CategoryId = "home", CategoryName = "Home" },
                new Category { CategoryId = "ex", CategoryName = "Exercise" },
                new Category { CategoryId = "shop", CategoryName = "Shop" },
                new Category { CategoryId = "call", CategoryName = "Call" }
            );

            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "open", StatusName = "Open" },
                new Status { StatusId = "closed", StatusName = "Closed" }
            );
        }
    }
}
