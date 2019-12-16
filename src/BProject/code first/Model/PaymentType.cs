using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_first.Model
{
    class PaymentType
    {
        public PaymentType()
        {
            this.Orders = new HashSet<Order>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
}
