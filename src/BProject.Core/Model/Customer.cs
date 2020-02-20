using BProject.Core.Model.Base;
using System.Collections.Generic;

namespace BProject.Core.Model
{
    public class Customer : BaseEntityWithTimestamp
    {
        public Customer()
        {
            this.Addresses = new HashSet<Address>();
            this.Orders = new HashSet<Order>();
        }

        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }        
        public virtual User User { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}