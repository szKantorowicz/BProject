using System.Data.Entity.ModelConfiguration;
using BProject.Core.Models;

namespace BProject.Infrastructure.EntityFramework.EntityTypeConfiguration
{
    class AddressConfiguration : EntityTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            HasKey(a => a.ID);

            Property(a => a.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();
                
            Property(a => a.City)
                .HasMaxLength(100)
                .IsRequired();

            Property(a => a.Street)
                .HasMaxLength(100)
                .IsRequired();

            Property(a => a.Postcode)
                .HasMaxLength(6)
                .IsRequired();

            Property(a => a.Level)
                .IsOptional();

            Property(a => a.CreatedDate)
                .IsRequired();

            Property(a => a.UpdatedDate)
                .IsOptional();
        }
    }
}
