﻿using BProject.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BProject.Core.EntityTypeConfiguration
{
    class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(u => u.ID);

            Property(u => u.Name)
                .HasMaxLength(100)
                .IsRequired();
            
            Property(u => u.Email)
                .HasMaxLength(100)
                .IsRequired();

            Property(u => u.Password)
                .HasMaxLength(200)
                .IsRequired();

            Property(u => u.CreatedDate)
                .IsRequired();

            Property(u => u.UpdatedDate)
                .IsOptional();


            HasRequired(u => u.Customer)
            .WithRequiredPrincipal(c => c.User);

            HasMany(u => u.Roles)
                .WithMany(r => r.Users)
                .Map(ur =>
                {
                    ur.MapLeftKey("UserID");
                    ur.MapRightKey("RoleID");
                    ur.ToTable("UserRole");
                });
        }
    }
}
