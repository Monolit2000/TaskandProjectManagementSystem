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
    public class TaskRepository : Repository<TaskProd>, ITaskRepository
    {
        private AppDbContext _appDbContext; 
        public TaskRepository(AppDbContext appContext) : base(appContext)
        {
            _appDbContext = appContext;
        }
    }
}
