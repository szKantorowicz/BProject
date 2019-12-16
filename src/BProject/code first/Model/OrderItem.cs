using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_first.Model
{
    class OrderItem
    {
        public int ID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}

