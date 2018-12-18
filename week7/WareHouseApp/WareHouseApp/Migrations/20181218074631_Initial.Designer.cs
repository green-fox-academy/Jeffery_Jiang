﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WareHouseApp;

namespace WareHouseApp.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20181218074631_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WareHouseApp.Models.Basket", b =>
                {
                    b.Property<long>("BasketId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt");

                    b.HasKey("BasketId");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("WareHouseApp.Models.BasketItem", b =>
                {
                    b.Property<long>("BasketItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("BasketId");

                    b.Property<long?>("GoodId");

                    b.Property<int>("Quantity");

                    b.HasKey("BasketItemId");

                    b.HasIndex("BasketId");

                    b.HasIndex("GoodId");

                    b.ToTable("BasketItem");
                });

            modelBuilder.Entity("WareHouseApp.Models.Good", b =>
                {
                    b.Property<long>("GoodId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("Stock");

                    b.HasKey("GoodId");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("WareHouseApp.Models.OrderHistory", b =>
                {
                    b.Property<long>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt");

                    b.Property<string>("CustomerName");

                    b.HasKey("OrderId");

                    b.ToTable("OrderHistory");
                });

            modelBuilder.Entity("WareHouseApp.Models.OrderItem", b =>
                {
                    b.Property<long>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("GoodId");

                    b.Property<long?>("OrderId");

                    b.Property<int>("Quantity");

                    b.HasKey("OrderItemId");

                    b.HasIndex("GoodId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("WareHouseApp.Models.BasketItem", b =>
                {
                    b.HasOne("WareHouseApp.Models.Basket", "Basket")
                        .WithMany()
                        .HasForeignKey("BasketId");

                    b.HasOne("WareHouseApp.Models.Good", "Good")
                        .WithMany()
                        .HasForeignKey("GoodId");
                });

            modelBuilder.Entity("WareHouseApp.Models.OrderItem", b =>
                {
                    b.HasOne("WareHouseApp.Models.Good", "Good")
                        .WithMany()
                        .HasForeignKey("GoodId");

                    b.HasOne("WareHouseApp.Models.OrderHistory", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");
                });
#pragma warning restore 612, 618
        }
    }
}