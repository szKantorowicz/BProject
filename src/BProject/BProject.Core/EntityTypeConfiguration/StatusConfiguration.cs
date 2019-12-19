﻿using Bproject.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BProject.Core.EntityTypeConfiguration
{
    public class StatusConfiguration : EntityTypeConfiguration<Status>
    {
        public StatusConfiguration()
        {
            HasKey(s => s.ID);

            Property(s => s.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(s => s.Name)
                .HasMaxLength(100)
                .IsRequired();

            HasMany(s => s.Orders)
               .WithOptional(o => o.Status)
               .HasForeignKey(o => o.StatusID);


        }
    }
}
