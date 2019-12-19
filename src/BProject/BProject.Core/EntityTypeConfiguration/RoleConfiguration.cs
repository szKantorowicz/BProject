using BProject.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BProject.Core.EntityTypeConfiguration
{
  class RoleConfiguration : EntityTypeConfiguration<Role>
  {
      public RoleConfiguration()
      {
                HasKey(r => r.ID);

                Property(r => r.ID)
                    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                    .IsRequired();

                Property(c => c.Name)
                    .HasMaxLength(100)
                    .IsRequired();
    }
   }
    
}
