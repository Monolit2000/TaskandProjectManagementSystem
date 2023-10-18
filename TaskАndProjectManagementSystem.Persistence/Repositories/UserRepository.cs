using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskАndProjectManagementSystem.Application.Contracts.Persistence;
using TaskАndProjectManagementSystem.Domain;
using TaskАndProjectManagementSystem.Persistence.Repositories.Generic;

namespace TaskАndProjectManagementSystem.Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
