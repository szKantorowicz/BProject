﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bproject.Core.Model
{
    class OrderItem
    {
        public int ID { get; set; }
        public int? OrderID { get; set; }
        public int? ProductID { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? Quantity { get; set; }
        public System.DateTime? UpdatedDate { get; set; }
        public System.DateTime? CreatedDate { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
