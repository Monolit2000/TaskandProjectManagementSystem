using TaskАndProjectManagementSystem.Application.Contracts.Persistence;
using TaskАndProjectManagementSystem.Domain;
using TaskАndProjectManagementSystem.Persistence.Repositories.Generic;

namespace TaskАndProjectManagementSystem.Persistence;
public class ProjectsRepository : Repository<Project>, IProjectsRepository
{
        private ApplicationDbContext _dbContext;
    public ProjectsRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }       
}
