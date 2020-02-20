using System.Collections.Generic;
using BProject.Core.Models.Base;

namespace BProject.Core.Models
{
    public class Order : BaseEntityWithTimestamp
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int CustomerID { get; set; }
        public decimal? TotalAmount { get; set; }
        public bool? IsPayed { get; set; }
        public int? PaymentTypeID { get; set; }
        public int? StatusID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual Status Status { get; set; }
  
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}

    
