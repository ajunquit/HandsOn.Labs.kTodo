using HandsOn.Labs.kTodo.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Labs.kTodo.Persistence.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository Users { get; }

        private readonly KTodoDbContext _dbContext;

        public UnitOfWork(IUserRepository userRepository, 
            KTodoDbContext dbContext)
        {
            Users = userRepository;
            _dbContext = dbContext;
        }

        public async Task<int> Save(CancellationToken cancellationToken)
        {
            return await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            System.GC.SuppressFinalize(this);
        }
    }
}
