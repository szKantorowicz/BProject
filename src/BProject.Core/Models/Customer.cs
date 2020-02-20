using System.Collections.Generic;
using BProject.Core.Models.Base;

namespace BProject.Core.Models
{
    public class Customer : BaseEntityWithTimestamp
    {
        public Customer()
        {
            Addresses = new HashSet<Address>();
            Orders = new HashSet<Order>();
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