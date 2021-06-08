﻿// <auto-generated />
using System;
using CRUD_with_ASP.NET.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD_with_ASP.NET.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210607165519_SeedingToProductTable")]
    partial class SeedingToProductTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CRUD_with_ASP.NET.Models.CustomerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Eamil")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CRUD_with_ASP.NET.Models.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "New device",
                            Name = "Phone",
                            Price = 532.2f
                        },
                        new
                        {
                            Id = 2,
                            Description = "Used before",
                            Name = "Laptop",
                            Price = 122.2f
                        },
                        new
                        {
                            Id = 3,
                            Description = "New type of TV",
                            Name = "TV",
                            Price = 532.2f
                        });
                });

            modelBuilder.Entity("CRUD_with_ASP.NET.Models.ShipmentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfDelivery")
                        .HasColumnType("datetime");

                    b.Property<string>("LocationOfDelivery")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Shipments");
                });
#pragma warning restore 612, 618
        }
    }
}
