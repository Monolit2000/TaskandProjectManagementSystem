using Microsoft.EntityFrameworkCore;
using TaskandProjectManagementSystem.Domain;

namespace TaskandProjectManagementSystem.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        DbSet<User> Users { get; set; } 
        DbSet<Project> Projects { get; set; }
        DbSet<TaskProd> Tasks { get; set; }
    }
}