using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bproject.Core.Model
{
    class Address
    {
        public int ID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public Nullable<int> Level { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
