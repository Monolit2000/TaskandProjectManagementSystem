using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskandProjectManagementSystem.Application.Contracts.Persistence;

namespace TaskandProjectManagementSystem.Persistence.Repositories.Generic
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _appContext;
        private DbSet<T> _entyntes;

        public Repository(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        private DbSet<T> Entytes
        {
            get
            {
                if (_entyntes == null)
                    _entyntes = _appContext.Set<T>();

                return _entyntes;
            }
        }

        public async Task<T> CreateAsync(T entity)
        {
            await Entytes.AddAsync(entity);
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            Entytes.Remove(entity);
        }

        public async Task<T> GetAsync(int id)
        {
            return await Entytes.FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _appContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
