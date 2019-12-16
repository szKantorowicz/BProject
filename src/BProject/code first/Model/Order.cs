using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_first.Model
{
    class Order
    {
    
        
        public Order()
        {
            this.OrderItems = new HashSet<OrderItem>();
        }

        public int ID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<bool> IsPayed { get; set; }
        public Nullable<int> PaymentTypeID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual Status Status1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}

    
