using BProject.Core.Model.Base;
using System.Collections.Generic;

namespace BProject.Core.Model
{
    public class Status : BaseEntity
    {
        public Status()
        {
            this.Orders = new HashSet<Order>();
        }

        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
