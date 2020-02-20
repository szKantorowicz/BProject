using System;

namespace BProject.Core.Model.Base
{
    public abstract class BaseEntityWithTimestamp : BaseEntity
    {
        public DateTime? UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
