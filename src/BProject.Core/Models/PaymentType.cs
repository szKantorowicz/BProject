using System.Collections.Generic;
using BProject.Core.Models.Base;

namespace BProject.Core.Models
{
    public class PaymentType : BaseEntity
    {
        public PaymentType()
        {
            Orders = new HashSet<Order>();
        }

        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}

