using HandsOn.Labs.kTodo.Application.Interfaces.Repositories;
using HandsOn.Labs.kTodo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Labs.kTodo.Persistence.Persistence.Repositories
{
    public class UserRepository: Repository<User>,  IUserRepository
    {
        private readonly KTodoDbContext _dbContext;

        public UserRepository(KTodoDbContext dbContext): base(dbContext)
        {
        }
    }
}
