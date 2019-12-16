using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_first.Model
{
    class Customer
    {
        public Customer()
        {
            this.Addresses = new HashSet<Address>();
            this.Orders = new HashSet<Order>();
        }

        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Order> Orders
        {
            get; set;
        }
    }
}
