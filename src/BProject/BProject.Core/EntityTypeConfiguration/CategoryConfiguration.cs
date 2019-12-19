using Bproject.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BProject.Core.EntityTypeConfiguration
{
    class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            HasKey(ca => ca.ID);

            Property(ca => ca.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(ca => ca.Name)
                .HasMaxLength(100)
                .IsRequired();

            Property(ca => ca.Description)
                .HasMaxLength(1000)
                .IsRequired();
        }
    }
}
