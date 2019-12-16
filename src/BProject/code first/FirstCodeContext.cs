using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using code_first.Model;

namespace code_first
{
    class FirstCodeContext: DbContext
    {
        public DbSet<User,Role,Customer,Product,Status,>
    }
}
