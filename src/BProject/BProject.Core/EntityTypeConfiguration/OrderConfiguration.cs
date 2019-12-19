using Bproject.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BProject.Core.EntityTypeConfiguration
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            HasKey(o => o.ID);

            Property(o => o.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(o => o.CustomerID)
                .IsRequired();

            Property(o => o.TotalAmount)
                .IsRequired();

            Property(o => o.IsPayed)
                 .IsRequired();

            Property(o => o.PaymentTypeID)
                 .IsRequired();

            Property(o => o.Status)
                 .IsRequired();

            Property(o => o.CreatedDate)
                 .IsRequired();

            Property(o => o.UpdatedDate)
                 .IsOptional();

            HasMany(o => o.OrderItems)
                .WithRequired(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderID);

        }
    }
}
