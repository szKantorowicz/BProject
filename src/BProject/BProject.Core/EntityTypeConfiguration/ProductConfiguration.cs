using Bproject.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BProject.Core.EntityTypeConfiguration
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(p => p.ID);

            Property(p => p.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.Description)
                .HasMaxLength(1000)
                .IsRequired();

            Property(p => p.Price)
                .IsRequired();

            Property(p => p.Quantityinstock)
                .IsRequired();

            Property(p => p.Avilability)
                .IsRequired();

            Property(p => p.CreatedDate)
                .IsRequired();

            Property(p => p.UpdatedDate)
                .IsOptional();

            HasMany(p => p.OrderItems)
                .WithRequired(oi => oi.Product)
                .HasForeignKey(oi => oi.ProductID);

            HasMany(p => p.Categories)
                .WithMany(ca => ca.Products)
                .Map(p =>
                {
                    p.MapLeftKey("ProductID");
                    p.MapRightKey("CategoryID");
                    p.ToTable("ProductCategory");
                });
        }

}    }        