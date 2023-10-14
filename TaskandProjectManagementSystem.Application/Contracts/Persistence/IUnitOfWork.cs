using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskandProjectManagementSystem.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        public IUserRepository UserRepository { get; set; }
        public IProjectsRepository ProjectsRepository { get; set; }





    }
}
