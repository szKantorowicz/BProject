using BProject.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BProject.Core.EntityTypeConfiguration
{
    class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            HasKey(c => c.ID);

            Property(c => c.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(c => c.FirstName)
                .HasMaxLength(100)
                .IsOptional();

            Property(c => c.LastName)
                .HasMaxLength(100)
                .IsOptional();

            Property(c => c.UserName)
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.Email)
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.Phone)
                .HasMaxLength(10)
                .IsOptional();

            HasMany(c => c.Addresses)
                .WithRequired(a => a.Customer)
                .HasForeignKey(a => a.CustomerID);

            HasMany(c => c.Orders)
                .WithRequired(o => o.Customer)
                .HasForeignKey(o => o.CustomerID);
        }
    }
}

