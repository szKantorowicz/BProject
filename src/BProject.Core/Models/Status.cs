using System.Collections.Generic;
using BProject.Core.Models.Base;

namespace BProject.Core.Models
{
    public class Status : BaseEntity
    {
        public Status()
        {
            Orders = new HashSet<Order>();
        }

        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
