using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOn.Labs.kTodo.Core.Common;

namespace HandsOn.Labs.kTodo.Core.Entities
{
    public class List: BaseAuditableEntity
    {
        public string Name { get; set; }
        List<HandsOn.Labs.kTodo.Core.Entities.Task> Tasks { get; set; }
    }
}
