﻿// <auto-generated />
using System;
using InventoryManagementSystem;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InventoryManagementSystem.Migrations
{
    [DbContext(typeof(EFModel))]
    partial class EFModelModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InventoryManagementSystem.Tables.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Fax")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Website")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("CustomerID");

                    b.HasIndex("Phone")
                        .IsUnique()
                        .HasFilter("[Phone] IS NOT NULL");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.Item", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemID"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ItemID");

                    b.ToTable("Items", (string)null);
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.ReleaseOrder", b =>
                {
                    b.Property<int>("ReleaseOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReleaseOrderID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("date");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("WarehouseID")
                        .HasColumnType("int");

                    b.HasKey("ReleaseOrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("WarehouseID");

                    b.ToTable("ReleaseOrders", (string)null);
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.ReleaseOrderDetail", b =>
                {
                    b.Property<int>("ReleaseOrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReleaseOrderDetailID"));

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ReleaseOrderID")
                        .HasColumnType("int");

                    b.HasKey("ReleaseOrderDetailID");

                    b.HasIndex("ItemID");

                    b.HasIndex("ReleaseOrderID");

                    b.ToTable("ReleaseOrderDetails", (string)null);
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.Stock", b =>
                {
                    b.Property<int>("StockID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockID"));

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseID")
                        .HasColumnType("int");

                    b.HasKey("StockID");

                    b.HasIndex("ItemID");

                    b.HasIndex("WarehouseID");

                    b.ToTable("Stocks", (string)null);
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.StockTransfer", b =>
                {
                    b.Property<int>("TransferID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransferID"));

                    b.Property<int>("FromWarehouseID")
                        .HasColumnType("int");

                    b.Property<int>("ToWarehouseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransferDate")
                        .HasColumnType("date");

                    b.HasKey("TransferID");

                    b.HasIndex("FromWarehouseID");

                    b.HasIndex("ToWarehouseID");

                    b.ToTable("StockTransfers", (string)null);
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.StockTransferDetail", b =>
                {
                    b.Property<int>("TransferDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransferDetailID"));

                    b.Property<int>("ExpirationPeriod")
                        .HasColumnType("int");

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("date");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SupplierID")
                        .HasColumnType("int");

                    b.Property<int>("TransferID")
                        .HasColumnType("int");

                    b.HasKey("TransferDetailID");

                    b.HasIndex("ItemID");

                    b.HasIndex("SupplierID");

                    b.HasIndex("TransferID");

                    b.ToTable("StockTransferDetails", (string)null);
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierID"));

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Fax")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Website")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("SupplierID");

                    b.HasIndex("Phone")
                        .IsUnique()
                        .HasFilter("[Phone] IS NOT NULL");

                    b.ToTable("Suppliers", (string)null);
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.SupplyOrder", b =>
                {
                    b.Property<int>("SupplyOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplyOrderID"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("date");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SupplierID")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseID")
                        .HasColumnType("int");

                    b.HasKey("SupplyOrderID");

                    b.HasIndex("SupplierID");

                    b.HasIndex("WarehouseID");

                    b.ToTable("SupplyOrders", (string)null);
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.SupplyOrderDetail", b =>
                {
                    b.Property<int>("SupplyOrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplyOrderDetailID"));

                    b.Property<int>("ExpirationPeriod")
                        .HasColumnType("int");

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("date");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SupplyOrderID")
                        .HasColumnType("int");

                    b.HasKey("SupplyOrderDetailID");

                    b.HasIndex("ItemID");

                    b.HasIndex("SupplyOrderID");

                    b.ToTable("SupplyOrderDetails", (string)null);
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.Warehouse", b =>
                {
                    b.Property<int>("WarehouseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WarehouseID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("WarehouseID");

                    b.ToTable("Warehouses", (string)null);
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.ReleaseOrder", b =>
                {
                    b.HasOne("InventoryManagementSystem.Tables.Customer", "Customer")
                        .WithMany("ReleaseOrders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Tables.Warehouse", "Warehouse")
                        .WithMany("ReleaseOrders")
                        .HasForeignKey("WarehouseID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.ReleaseOrderDetail", b =>
                {
                    b.HasOne("InventoryManagementSystem.Tables.Item", "Item")
                        .WithMany("ReleaseOrderDetails")
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Tables.ReleaseOrder", "ReleaseOrder")
                        .WithMany("ReleaseOrderDetails")
                        .HasForeignKey("ReleaseOrderID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("ReleaseOrder");
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.Stock", b =>
                {
                    b.HasOne("InventoryManagementSystem.Tables.Item", "Item")
                        .WithMany("Stocks")
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Tables.Warehouse", "Warehouse")
                        .WithMany("Stocks")
                        .HasForeignKey("WarehouseID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.StockTransfer", b =>
                {
                    b.HasOne("InventoryManagementSystem.Tables.Warehouse", "FromWarehouse")
                        .WithMany("StockTransfers")
                        .HasForeignKey("FromWarehouseID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Tables.Warehouse", "ToWarehouse")
                        .WithMany("StockTransfers1")
                        .HasForeignKey("ToWarehouseID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("FromWarehouse");

                    b.Navigation("ToWarehouse");
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.StockTransferDetail", b =>
                {
                    b.HasOne("InventoryManagementSystem.Tables.Item", "Item")
                        .WithMany("StockTransferDetails")
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Tables.Supplier", "Supplier")
                        .WithMany("StockTransferDetails")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Tables.StockTransfer", "StockTransfer")
                        .WithMany("StockTransferDetails")
                        .HasForeignKey("TransferID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("StockTransfer");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.SupplyOrder", b =>
                {
                    b.HasOne("InventoryManagementSystem.Tables.Supplier", "Supplier")
                        .WithMany("SupplyOrders")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Tables.Warehouse", "Warehouse")
                        .WithMany("SupplyOrders")
                        .HasForeignKey("WarehouseID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Supplier");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.SupplyOrderDetail", b =>
                {
                    b.HasOne("InventoryManagementSystem.Tables.Item", "Item")
                        .WithMany("SupplyOrderDetails")
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Tables.SupplyOrder", "SupplyOrder")
                        .WithMany("SupplyOrderDetails")
                        .HasForeignKey("SupplyOrderID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("SupplyOrder");
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.Customer", b =>
                {
                    b.Navigation("ReleaseOrders");
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.Item", b =>
                {
                    b.Navigation("ReleaseOrderDetails");

                    b.Navigation("StockTransferDetails");

                    b.Navigation("Stocks");

                    b.Navigation("SupplyOrderDetails");
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.ReleaseOrder", b =>
                {
                    b.Navigation("ReleaseOrderDetails");
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.StockTransfer", b =>
                {
                    b.Navigation("StockTransferDetails");
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.Supplier", b =>
                {
                    b.Navigation("StockTransferDetails");

                    b.Navigation("SupplyOrders");
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.SupplyOrder", b =>
                {
                    b.Navigation("SupplyOrderDetails");
                });

            modelBuilder.Entity("InventoryManagementSystem.Tables.Warehouse", b =>
                {
                    b.Navigation("ReleaseOrders");

                    b.Navigation("StockTransfers");

                    b.Navigation("StockTransfers1");

                    b.Navigation("Stocks");

                    b.Navigation("SupplyOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
