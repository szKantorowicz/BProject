using System.Collections.Generic;
using BProject.Core.Models.Base;

namespace BProject.Core.Models
{
    public class User : BaseEntityWithTimestamp
    {
        public User()
        {
            Roles = new HashSet<Role>();
        }

        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual Customer Customer { get; set; }

        public HashSet<Role> Roles { get; }
    }
}
