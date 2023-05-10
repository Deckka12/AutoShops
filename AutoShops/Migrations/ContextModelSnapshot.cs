﻿// <auto-generated />
using System;
using AutoShops;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutoShops.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AutoShops.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Administration")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("AutoShops.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("CostOrder")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<bool>("IsNotCountShop")
                        .HasColumnType("bit");

                    b.Property<int>("ProductIdProduct")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductIdProduct");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("AutoShops.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NameCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("AutoShops.Models.Clients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Addres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("AutoShops.Models.Order", b =>
                {
                    b.Property<int>("IdOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdOrder"));

                    b.Property<int>("ClientsId")
                        .HasColumnType("int")
                        .HasColumnName("ClientId")
                        .HasColumnOrder(0);

                    b.Property<decimal>("CostOrder")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateDeliveri")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumberOrder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StateOrderId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.HasKey("IdOrder");

                    b.HasIndex("ClientsId");

                    b.HasIndex("StateOrderId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("AutoShops.Models.Product", b =>
                {
                    b.Property<int>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProduct"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdProduct");

                    b.HasIndex("CategoryID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("AutoShops.Models.ProductOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Sum")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("productId");

                    b.ToTable("ProductOrder");
                });

            modelBuilder.Entity("AutoShops.Models.StateOrder", b =>
                {
                    b.Property<int>("IdState")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdState"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdState");

                    b.ToTable("StateOrder");
                });

            modelBuilder.Entity("AutoShops.Models.Storage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("IDproduct")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IDproduct");

                    b.ToTable("Storage");
                });

            modelBuilder.Entity("AutoShops.Models.Cart", b =>
                {
                    b.HasOne("AutoShops.Models.Product", "Product")
                        .WithMany("Cart")
                        .HasForeignKey("ProductIdProduct")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AutoShops.Models.Order", b =>
                {
                    b.HasOne("AutoShops.Models.Clients", "Clients")
                        .WithMany("Order")
                        .HasForeignKey("ClientsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AutoShops.Models.StateOrder", "StateOrder")
                        .WithMany("Order")
                        .HasForeignKey("StateOrderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Clients");

                    b.Navigation("StateOrder");
                });

            modelBuilder.Entity("AutoShops.Models.Product", b =>
                {
                    b.HasOne("AutoShops.Models.Category", "Category")
                        .WithMany("Product")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("AutoShops.Models.ProductOrder", b =>
                {
                    b.HasOne("AutoShops.Models.Order", "order")
                        .WithMany("ItemsOrder")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AutoShops.Models.Product", "product")
                        .WithMany("ProductOrder")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("order");

                    b.Navigation("product");
                });

            modelBuilder.Entity("AutoShops.Models.Storage", b =>
                {
                    b.HasOne("AutoShops.Models.Product", "product")
                        .WithMany("Storage")
                        .HasForeignKey("IDproduct")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("AutoShops.Models.Category", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("AutoShops.Models.Clients", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("AutoShops.Models.Order", b =>
                {
                    b.Navigation("ItemsOrder");
                });

            modelBuilder.Entity("AutoShops.Models.Product", b =>
                {
                    b.Navigation("Cart");

                    b.Navigation("ProductOrder");

                    b.Navigation("Storage");
                });

            modelBuilder.Entity("AutoShops.Models.StateOrder", b =>
                {
                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}