using BProject.Core.Model;
using System.Data.Entity.ModelConfiguration;

namespace BProject.Core.EntityTypeConfiguration
{
    public class StatusConfiguration : EntityTypeConfiguration<Status>
    {
        public StatusConfiguration()
        {
            HasKey(s => s.ID);

            Property(s => s.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(s => s.Name)
                .HasMaxLength(100)
                .IsRequired();

            HasMany(s => s.Orders)
               .WithOptional(o => o.Status)
               .HasForeignKey(o => o.StatusID);
        }
    }
}
