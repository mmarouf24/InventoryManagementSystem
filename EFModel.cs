using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Tables;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem
{
    public class EFModel:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=WarehouseDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;");
        }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ReleaseOrderDetail> ReleaseOrderDetails { get; set; }
        public virtual DbSet<ReleaseOrder> ReleaseOrders { get; set; }
        public virtual DbSet<SupplyOrderDetail> SupplyOrderDetails { get; set; }
        public virtual DbSet<SupplyOrder> SupplyOrders { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<StockTransferDetail> StockTransferDetails { get; set; }
        public virtual DbSet<StockTransfer> StockTransfers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.ReleaseOrders)
                .WithOne(e => e.Customer)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.ReleaseOrderDetails)
                .WithOne(e => e.Item)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Stocks)
                .WithOne(e => e.Item)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.SupplyOrderDetails)
                .WithOne(e => e.Item)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ReleaseOrder>()
                .HasMany(e => e.ReleaseOrderDetails)
                .WithOne(e => e.ReleaseOrder)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.SupplyOrders)
                .WithOne(e => e.Supplier)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SupplyOrder>()
                .HasMany(e => e.SupplyOrderDetails)
                .WithOne(e => e.SupplyOrder)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.ReleaseOrders)
                .WithOne(e => e.Warehouse)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Stocks)
                .WithOne(e => e.Warehouse)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.StockTransfers)
                .WithOne(e => e.Warehouse)
                .HasForeignKey(e => e.FromWarehouseID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.StockTransfers1)
                .WithOne(e => e.Warehouse1)
                .HasForeignKey(e => e.ToWarehouseID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.SupplyOrders)
                .WithOne(e => e.Warehouse)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
