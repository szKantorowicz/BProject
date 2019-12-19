using BProject.Core.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bproject.Core.Model
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
        public int? Quantityinstock { get; set; }
        public bool? Avilability { get; set; }
        
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}

