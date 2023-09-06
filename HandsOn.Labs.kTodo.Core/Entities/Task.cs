using HandsOn.Labs.kTodo.Core.Common;
using HandsOn.Labs.kTodo.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Labs.kTodo.Core.Entities
{
    public class Task: BaseAuditableEntity
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime? Date { get; set; }
        public EnumLabelTask? Label { get; set; }
        public List List { get; set; }
    }
}
