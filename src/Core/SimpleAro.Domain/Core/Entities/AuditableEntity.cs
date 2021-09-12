using System;

namespace SimpleAro.Domain.Core.Entities
{
    public class AuditableEntity
    {
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
    }
}
