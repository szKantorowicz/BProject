using BProject.Core.EntityTypeConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BProject.Core.Model
{
    class BProjectContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
      
        public BProjectContext()
            :base("Shop")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new OrderItemConfiguration());
            modelBuilder.Configurations.Add(new PaymentTypeConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
            modelBuilder.Configurations.Add(new StatusConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());

            base.OnModelCreating(modelBuilder);
        }
        
    }
}

