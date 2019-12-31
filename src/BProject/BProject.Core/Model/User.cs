using BProject.Core.Model.Base;
using System.Collections.Generic;

namespace BProject.Core.Model
{
    public class User : BaseEntityWithTimestamp
    {
        public User()
        {
            this.Roles = new HashSet<Role>();
        }

        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual Customer Customer { get; set; }

        public HashSet<Role> Roles { get; }
    }
}
