using TaskАndProjectManagementSystem.Application.Contracts.Persistence;
using TaskАndProjectManagementSystem.Persistence.Repositories;

namespace TaskАndProjectManagementSystem.Persistence;
public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    public IUserRepository _userRepository;
    public IProjectsRepository _projectsRepository;
    public ITaskRepository _taskRepository;

    public UnitOfWork(ApplicationDbContext DBcontext)
    {
        _context = DBcontext;
    }

    public IUserRepository UserRepository =>
        _userRepository ??= new UserRepository(_context);

    public IProjectsRepository ProjectsRepository => throw new NotImplementedException();

    public ITaskRepository TaskRepository => throw new NotImplementedException();

    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }
}
