using HandsOn.Labs.kTodo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Labs.kTodo.Persistence.Persistence
{
    public class KTodoDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<HandsOn.Labs.kTodo.Core.Entities.Task> Tasks{ get; set; }
        public KTodoDbContext(DbContextOptions<KTodoDbContext> options): base(options)
        {
            
        }
    }
}
