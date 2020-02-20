using BProject.Core.Model.Base;
using System.Collections.Generic;

namespace BProject.Core.Model
{
    public class Role : BaseEntityWithTimestamp
    {
        public Role()
        {
            this.Users = new HashSet<User>();
        }

        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}