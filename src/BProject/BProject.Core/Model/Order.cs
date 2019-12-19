using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bproject.Core.Model
{
    public class Order
    {
    
        
        public Order()
        {
            this.OrderItems = new HashSet<OrderItem>();
        }

        public int ID { get; set; }
        public int? CustomerID { get; set; }
        public decimal? TotalAmount { get; set; }
        public bool? IsPayed { get; set; }
        public int? PaymentTypeID { get; set; }
        public int? StatusID { get; set; }
        public System.DateTime? UpdatedDate { get; set; }
        public System.DateTime? CreatedDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual Status Status { get; set; }
  
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}

    
