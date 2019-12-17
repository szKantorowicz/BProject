using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bproject.Core.Model
{
    class Role
    {

        public Role()
        {
            this.Users = new HashSet<User>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public System.DateTime? UpdatedDate { get; set; }
        public System.DateTime? CreatedDate { get; set; }

        public virtual ICollection<User> Users { get; set; }

    }
}