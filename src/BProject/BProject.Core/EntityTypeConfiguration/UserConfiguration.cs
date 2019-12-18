using Bproject.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BProject.Core.EntityTypeConfiguration
{
    class UserConfiguration : EntityTypeConfiguration<User>
    {
        public AddressConfiguration()
        {

        }
    }
}
