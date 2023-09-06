using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOn.Labs.kTodo.Core.Common;

namespace HandsOn.Labs.kTodo.Core.Entities
{
    public class User: BaseAuditableEntity
    {
        public string Name { get; set; }
        public List<Board> Boards { get; set; }

    }
}
