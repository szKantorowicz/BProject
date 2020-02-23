using System.Data.Entity.ModelConfiguration;
using BProject.Core.Models;

namespace BProject.Infrastructure.EntityFramework.EntityTypeConfiguration
{
    public class OrderItemConfiguration : EntityTypeConfiguration<OrderItem>
    {
        public OrderItemConfiguration()
        {
            HasKey(oi => oi.ID);

            Property(oi => oi.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(oi => oi.CreatedDate)
                .IsRequired();

            Property(oi => oi.UpdatedDate)
                .IsOptional();

            Property(oi => oi.Quantity)
                .IsRequired();

            Property(oi => oi.TotalPrice)
                .IsRequired();

            Property(oi => oi.UnitPrice)
                .IsRequired();
        }
    }
}
