using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Labs.kTodo.Application.Interfaces.Repositories
{
    public interface IUnitOfWork: IDisposable
    {
        IUserRepository Users { get; }
        Task<int> Save(CancellationToken cancellationToken);
    }
}
