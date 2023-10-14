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
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
