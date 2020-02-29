using System.Data.Entity.ModelConfiguration;
using BProject.Core.Models;

namespace BProject.Infrastructure.EntityFramework.EntityTypeConfiguration
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
