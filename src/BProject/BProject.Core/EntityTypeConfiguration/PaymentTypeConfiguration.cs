using BProject.Core.Model;
using System.Data.Entity.ModelConfiguration;

namespace BProject.Core.EntityTypeConfiguration
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
