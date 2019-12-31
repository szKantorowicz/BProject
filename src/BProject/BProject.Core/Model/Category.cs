using BProject.Core.Model.Base;
using System.Collections.Generic;

namespace BProject.Core.Model
{
    public class Category : BaseEntity
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }

        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
