using BProject.Core.Model;
using System.Data.Entity.ModelConfiguration;

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

            Property(o => o.TotalAmount)
                .IsOptional();

            Property(o => o.IsPayed)
                 .IsOptional();

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
