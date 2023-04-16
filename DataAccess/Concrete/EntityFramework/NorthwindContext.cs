using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını bağlamak.
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-1NLBACI\SQLSERVER;Database=Northwind;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<Category>().Property(c=>c.CategoryId).HasColumnName("CategoryID");
            modelBuilder.Entity<Category>().Property(c=>c.CategoryName).HasColumnName("CategoryName");

            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Customer>().Property(c => c.CustomerId).HasColumnName("CustomerID");
            modelBuilder.Entity<Customer>().Property(c => c.ContactName).HasColumnName("ContactName");
            modelBuilder.Entity<Customer>().Property(c => c.Company).HasColumnName("CompanyName");
            modelBuilder.Entity<Customer>().Property(c => c.City).HasColumnName("City");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
