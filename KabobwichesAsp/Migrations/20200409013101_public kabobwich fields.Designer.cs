﻿// <auto-generated />
using System;
using KabobwichesAsp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KabobwichesAsp.Migrations
{
    [DbContext(typeof(Repository))]
    [Migration("20200409013101_public kabobwich fields")]
    partial class publickabobwichfields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KabobwichesAsp.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("PostalCode");

                    b.Property<string>("StreetAddress");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("KabobwichesAsp.Models.Kabobwich", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bread");

                    b.Property<int>("Meat");

                    b.Property<int?>("OrderId");

                    b.Property<int>("Sauce");

                    b.Property<string>("Toppings");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Kabobwiches");
                });

            modelBuilder.Entity("KabobwichesAsp.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DeliveryAddressId");

                    b.Property<string>("Drinks");

                    b.Property<int?>("PaymentInformationId");

                    b.Property<string>("Sides");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryAddressId");

                    b.HasIndex("PaymentInformationId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("KabobwichesAsp.Models.PaymentInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BillingAddressId");

                    b.Property<int>("CardNum");

                    b.Property<int>("CardType");

                    b.Property<string>("CardholderName");

                    b.Property<int>("SecurityCode");

                    b.HasKey("Id");

                    b.HasIndex("BillingAddressId");

                    b.ToTable("PaymentInfos");
                });

            modelBuilder.Entity("KabobwichesAsp.Models.Kabobwich", b =>
                {
                    b.HasOne("KabobwichesAsp.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("KabobwichesAsp.Models.Order", b =>
                {
                    b.HasOne("KabobwichesAsp.Models.Address", "DeliveryAddress")
                        .WithMany()
                        .HasForeignKey("DeliveryAddressId");

                    b.HasOne("KabobwichesAsp.Models.PaymentInformation", "PaymentInformation")
                        .WithMany()
                        .HasForeignKey("PaymentInformationId");
                });

            modelBuilder.Entity("KabobwichesAsp.Models.PaymentInformation", b =>
                {
                    b.HasOne("KabobwichesAsp.Models.Address", "BillingAddress")
                        .WithMany()
                        .HasForeignKey("BillingAddressId");
                });
#pragma warning restore 612, 618
        }
    }
}
