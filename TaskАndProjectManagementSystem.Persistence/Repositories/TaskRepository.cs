using TaskАndProjectManagementSystem.Application.Contracts.Persistence;
using TaskАndProjectManagementSystem.Domain;
using TaskАndProjectManagementSystem.Persistence.Repositories.Generic;

namespace TaskАndProjectManagementSystem.Persistence;
public class TaskRepository : Repository<TaskProd>
{
    private ApplicationDbContext _dbContext;
    public TaskRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
}
