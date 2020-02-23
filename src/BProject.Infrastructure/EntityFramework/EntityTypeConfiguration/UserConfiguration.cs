using System.Data.Entity.ModelConfiguration;
using BProject.Core.Models;

namespace BProject.Infrastructure.EntityFramework.EntityTypeConfiguration
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
                .WithMany()
                .HasForeignKey(u => u.CustomerID);

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
