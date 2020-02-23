using System.Data.Entity.ModelConfiguration;
using BProject.Core.Models;

namespace BProject.Infrastructure.EntityFramework.EntityTypeConfiguration
{
    public class PaymentTypeConfiguration : EntityTypeConfiguration<PaymentType>
    {
        public PaymentTypeConfiguration()
        {
            HasKey(pt => pt.ID);

            Property(pt => pt.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(pt => pt.Name)
                .HasMaxLength(100)
                .IsRequired();

            HasMany(pt => pt.Orders)
               .WithOptional(o => o.PaymentType)
               .HasForeignKey(o => o.PaymentTypeID);
        }
    }
}
