using BProject.Core.Model;
using System.Data.Entity.ModelConfiguration;

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
