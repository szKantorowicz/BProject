using BProject.Core.Model.Base;
using System.Collections.Generic;

namespace BProject.Core.Model
{
    public class Product : BaseEntityWithTimestamp
    {
        public Product()
        {
            this.OrderItems = new HashSet<OrderItem>();
            this.Categories = new HashSet<Category>();
        }

        public int Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int? QuantityInStock { get; set; }
        public bool? Availability { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}

