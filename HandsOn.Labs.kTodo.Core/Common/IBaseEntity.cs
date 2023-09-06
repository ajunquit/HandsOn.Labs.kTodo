using HandsOn.Labs.kTodo.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Labs.kTodo.Core.Common
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
    }
}
