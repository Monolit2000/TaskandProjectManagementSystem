using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskandProjectManagementSystem.Application.Contracts.Persistence;

namespace TaskandProjectManagementSystem.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository UserRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IProjectsRepository ProjectsRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
