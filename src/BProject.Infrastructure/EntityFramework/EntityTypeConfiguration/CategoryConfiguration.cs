﻿using System.Data.Entity.ModelConfiguration;
using BProject.Core.Models;

namespace BProject.Infrastructure.EntityFramework.EntityTypeConfiguration
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
                .IsOptional();
        }
    }
}