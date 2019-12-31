﻿using BProject.Core.Model;
using System.Data.Entity.ModelConfiguration;

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

            Property(p => p.QuantityInStock)
                .IsRequired();

            Property(p => p.Availability)
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