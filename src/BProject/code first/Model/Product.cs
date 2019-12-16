using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_first.Model
{
    class Product
    {
        public Product()
        {
            this.OrderItems = new HashSet<OrderItem>();
            this.Categories = new HashSet<Category>();
        }

        public int ID { get; set; }
        public Nullable<int> Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> Quantityinstock { get; set; }
        public Nullable<bool> Avilability { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category> Categories { get; set; }
    }
}

