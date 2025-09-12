using Day02_EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_EntityFramework.Context
{
    public class E_commerceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MAHMOUDAKL\\SQL22;Database=E_commerce;Integrated Security=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(eb =>
                   {
                       eb.HasKey(e => e.CategoryId);
                       eb.HasMany(e => e.products)
                           .WithOne(e => e.Category)
                           .HasForeignKey(e => e.CategoryId)
                           .OnDelete(DeleteBehavior.Restrict);
                   });
            modelBuilder.Entity<Product>(eb =>
            {
                eb.HasKey(e => e.ProductId);
                eb.Property(e => e.Name).IsRequired().HasMaxLength(20);
                eb.Property(e => e.Price).IsRequired().HasColumnType("decimal(20,2)");
            });
            modelBuilder.Entity<Customer>(eb =>
            {
                eb.HasKey(e => e.CustomerId);
                eb.Property(c => c.Name).IsRequired().HasMaxLength(150);
                eb.Property(c => c.Email).IsRequired().HasMaxLength(200);
                eb.HasMany(e => e.Orders)
                .WithOne(e => e.Customer)
                .HasForeignKey(e => e.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<Order>(eb =>
            {
                eb.HasKey(o => o.OrderId);
                eb.Property(o => o.OrderDate).IsRequired();
            });
            modelBuilder.Entity<OrderDetail>(eb =>
            {
                eb.HasKey(o => new { o.OrderId, o.ProductId });

                eb.HasOne(e => e.Product)
                   .WithMany(e => e.OrderDetails)
                   .HasForeignKey(e => e.ProductId)
                   .OnDelete(DeleteBehavior.Restrict);

                eb.HasOne(e => e.Order)
                   .WithMany(e => e.OrderDetails)
                   .HasForeignKey(e => e.OrderId)
                   .OnDelete(DeleteBehavior.Restrict);

                eb.Property(od => od.Quantity).IsRequired();
            });
        }
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }

    }
}
