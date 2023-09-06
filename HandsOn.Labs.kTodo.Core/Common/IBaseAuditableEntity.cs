using HandsOn.Labs.kTodo.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Labs.kTodo.Core.Common
{
    public interface IBaseAuditableEntity
    {
        EnumIsActive IsActive { get; set; }
        string CreatedBy { get; set; }
        string UpdatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime? UpdatedDate { get; set; }
    }
}
