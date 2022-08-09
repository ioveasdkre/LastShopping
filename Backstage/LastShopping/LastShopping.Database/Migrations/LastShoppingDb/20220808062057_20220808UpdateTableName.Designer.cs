﻿// <auto-generated />
using System;
using LastShopping.Database.DbContextModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LastShopping.Database.Migrations.LastShoppingDb
{
    [DbContext(typeof(LastShoppingDbContext))]
    [Migration("20220808062057_20220808UpdateTableName")]
    partial class _20220808UpdateTableName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LastShopping.Database.LastShoppingModels.Factory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Factory");
                });

            modelBuilder.Entity("LastShopping.Database.LastShoppingModels.ProductImg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductInformationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("ProductInformationId");

                    b.ToTable("ProductImgs");
                });

            modelBuilder.Entity("LastShopping.Database.LastShoppingModels.ProductInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FactoryId")
                        .HasColumnType("int");

                    b.Property<int>("Inventory")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("SellPrice")
                        .HasColumnType("int");

                    b.Property<int>("SuggestedPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.HasIndex("Id");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductInformation");
                });

            modelBuilder.Entity("LastShopping.Database.LastShoppingModels.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("ProductType");
                });

            modelBuilder.Entity("LastShopping.Database.LastShoppingModels.PurchaseOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("PurchaseOrders");
                });

            modelBuilder.Entity("LastShopping.Database.LastShoppingModels.PurchaseOrderDetails", b =>
                {
                    b.Property<int>("PurchaseOrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductInformationId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<bool>("check")
                        .HasColumnType("bit");

                    b.HasKey("PurchaseOrderId", "ProductInformationId");

                    b.HasIndex("ProductInformationId");

                    b.HasIndex("PurchaseOrderId");

                    b.ToTable("PurchaseOrderDetails");
                });

            modelBuilder.Entity("LastShopping.Database.LastShoppingModels.SalesOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SalesOrders");
                });

            modelBuilder.Entity("LastShopping.Database.LastShoppingModels.SalesOrderDetails", b =>
                {
                    b.Property<int>("SalesOrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductInformationId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("SalesOrderId", "ProductInformationId");

                    b.HasIndex("ProductInformationId");

                    b.HasIndex("SalesOrderId");

                    b.ToTable("SalesOrderDetails");
                });

            modelBuilder.Entity("LastShopping.Database.LastShoppingModels.ProductImg", b =>
                {
                    b.HasOne("LastShopping.Database.LastShoppingModels.ProductInformation", "ProductInformation")
                        .WithMany("ProductImgs")
                        .HasForeignKey("ProductInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductInformation");
                });

            modelBuilder.Entity("LastShopping.Database.LastShoppingModels.ProductInformation", b =>
                {
                    b.HasOne("LastShopping.Database.LastShoppingModels.Factory", "Factory")
                        .WithMany("ProductInformations")
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LastShopping.Database.LastShoppingModels.ProductType", "ProductType")
                        .WithMany("ProductInformations")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factory");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("LastShopping.Database.LastShoppingModels.PurchaseOrderDetails", b =>
                {
                    b.HasOne("LastShopping.Database.LastShoppingModels.ProductInformation", "ProductInformation")
                        .WithMany("PurchaseOrderDetails")
                        .HasForeignKey("ProductInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LastShopping.Database.LastShoppingModels.PurchaseOrder", "PurchaseOrder")
                        .WithMany("PurchaseOrderDetails")
                        .HasForeignKey("PurchaseOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductInformation");

                    b.Navigation("PurchaseOrder");
                });

            modelBuilder.Entity("LastShopping.Database.LastShoppingModels.SalesOrderDetails", b =>
                {
                    b.HasOne("LastShopping.Database.LastShoppingModels.ProductInformation", "ProductInformation")
                        .WithMany()
                        .HasForeignKey("ProductInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LastShopping.Database.LastShoppingModels.SalesOrder", "SalesOrder")
                        .WithMany()
                        .HasForeignKey("SalesOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductInformation");

                    b.Navigation("SalesOrder");
                });

            modelBuilder.Entity("LastShopping.Database.LastShoppingModels.Factory", b =>
                {
                    b.Navigation("ProductInformations");
                });

            modelBuilder.Entity("LastShopping.Database.LastShoppingModels.ProductInformation", b =>
                {
                    b.Navigation("ProductImgs");

                    b.Navigation("PurchaseOrderDetails");
                });

            modelBuilder.Entity("LastShopping.Database.LastShoppingModels.ProductType", b =>
                {
                    b.Navigation("ProductInformations");
                });

            modelBuilder.Entity("LastShopping.Database.LastShoppingModels.PurchaseOrder", b =>
                {
                    b.Navigation("PurchaseOrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}