using Microsoft.EntityFrameworkCore;
using TaskАndProjectManagementSystem.Domain;

namespace TaskАndProjectManagementSystem.Persistence;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
                
    }
    DbSet<User> Users { get; set; }
    DbSet<Project> Projects { get; set; }
    DbSet<TaskProd> Tasks { get; set; }
}
