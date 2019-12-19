using BProject.Core.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bproject.Core.Model
{
    public class Address : BaseEntityWithTimestamp
    {
        public int? CustomerID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public int? Level { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
