using BProject.Core.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
