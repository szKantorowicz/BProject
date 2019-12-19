﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bproject.Core.Model
{
    public class User
    {
        public User()
        {
            this.Roles = new HashSet<Role>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public System.DateTime? UpdatedDate { get; set; }
        public System.DateTime? CreatedDate { get; set; }
        public Customer Customer { get; set; }
        
        
        public HashSet<Role> Roles { get; }
    }
}
