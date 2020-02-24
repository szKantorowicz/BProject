﻿using System.Data.Entity;
using BProject.Core.Models;
using BProject.Infrastructure.EntityFramework.EntityTypeConfiguration;

namespace BProject.Infrastructure.EntityFramework
{
    public class BProjectContext : DbContext, IUnitOfWork
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
            : base("Shop_ConnectionStrings")
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

        public DbContextTransaction BeginTransaction()
        {
            return Database.BeginTransaction();
        }

        public void Rollback(DbContextTransaction transaction)
        {
            transaction.Rollback();
        }

        public void CommitTransaction(DbContextTransaction transaction)
        {
            try
            {
                SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
            }
        }

        public void SaveEntities()
        {
            SaveChanges();
        }
    }
}

