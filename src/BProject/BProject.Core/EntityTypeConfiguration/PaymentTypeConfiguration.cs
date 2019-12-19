using Bproject.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
