using HandsOn.Labs.kTodo.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HandsOn.Labs.kTodo.Persistence.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly KTodoDbContext _dbContext;
        protected readonly DbSet<TEntity> _entities;

        public Repository(KTodoDbContext dbContext)
        {
            this._dbContext = dbContext;
            this._entities = dbContext.Set<TEntity>();
        }
        public int Count()
        {
            return _entities.Count();
        }

        public async Task<int> CountAsync()
        {
            return await _entities.CountAsync();
        }

        public bool Delete(string id)
        {
            TEntity entity = Get(id);
            if (entity != null)
            {
                _entities.Remove(entity);
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            TEntity entity = await GetAsync(id);
            if (entity != null)
            {
                _entities.Remove(entity);
                return await Task.FromResult(true);
            }
            return await Task.FromResult(false);
        }

        public TEntity Get(string id)
        {
            return _entities.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entities.ToList();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _entities.ToListAsync();

        }

        public IEnumerable<TEntity> GetAllWithPagination(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> GetAllWithPaginationAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> GetAsync(string id)
        {
            return await _entities.FindAsync(id);
        }

        public bool Insert(TEntity entity)
        {
            _entities.Add(entity);
            return true;
        }

        public async Task<bool> InsertAsync(TEntity entity)
        {
            await _entities.AddAsync(entity);
            return await Task.FromResult(true);
        }

        public bool Update(TEntity entity)
        {
            _entities.Update(entity);
            return true;
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            _entities.Update(entity);
            return await Task.FromResult(true);
        }
    }
}
