using BProject.Core.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bproject.Core.Model
{
    public class User : BaseEntityWithTimestamp
    {
        public User()
        {
            this.Roles = new HashSet<Role>();
        }
        
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
 
        public Customer Customer { get; set; }
        
        
        public HashSet<Role> Roles { get; }
    }
}
