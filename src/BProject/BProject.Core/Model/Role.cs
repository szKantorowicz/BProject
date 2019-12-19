using BProject.Core.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bproject.Core.Model
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