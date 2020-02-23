using System;

namespace BProject.Core.Models.Base
{
    public abstract class BaseEntityWithTimestamp : BaseEntity
    {
        public DateTime? UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
