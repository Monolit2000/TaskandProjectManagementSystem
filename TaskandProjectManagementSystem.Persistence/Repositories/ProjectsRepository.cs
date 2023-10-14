using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskandProjectManagementSystem.Application.Contracts.Persistence;
using TaskandProjectManagementSystem.Domain;
using TaskandProjectManagementSystem.Persistence.Repositories.Generic;

namespace TaskandProjectManagementSystem.Persistence.Repositories
{
    public class ProjectsRepository : Repository<Project> , IProjectsRepository
    {
        private AppDbContext _appDbContext;
        public ProjectsRepository(AppDbContext appContext) : base(appContext)
        {
            _appDbContext = appContext;
        }
    }
}
