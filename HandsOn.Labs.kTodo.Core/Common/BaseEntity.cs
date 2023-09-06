using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Labs.kTodo.Core.Common
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }
    }
}
