using BProject.Core.Models.Base;

namespace BProject.Core.Models
{
    public class OrderItem : BaseEntityWithTimestamp
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}

