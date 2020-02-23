using System.Collections.Generic;
using BProject.Core.Models.Base;

namespace BProject.Core.Models
{
    public class Product : BaseEntityWithTimestamp
    {
        public Product()
        {
            OrderItems = new HashSet<OrderItem>();
            Categories = new HashSet<Category>();
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

