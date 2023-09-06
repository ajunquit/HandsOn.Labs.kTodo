using HandsOn.Labs.kTodo.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Labs.kTodo.Core.Common
{
    public class BaseAuditableEntity : IBaseAuditableEntity, IBaseEntity
    {
        public Guid Id { get; set; }

        [MaxLength(256)]
        public string CreatedBy { get; set; }
        [MaxLength(256)]
        public string? UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public EnumIsActive IsActive { get; set; } = EnumIsActive.Yes;
        
    }
}
