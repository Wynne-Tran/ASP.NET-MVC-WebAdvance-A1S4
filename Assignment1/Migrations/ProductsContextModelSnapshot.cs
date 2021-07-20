﻿// <auto-generated />
using System;
using Assignment1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment1.Migrations
{
    [DbContext(typeof(ProductsContext))]
    partial class ProductsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Assignment1.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            Name = "Canada"
                        },
                        new
                        {
                            CountryId = 2,
                            Name = "USA"
                        },
                        new
                        {
                            CountryId = 3,
                            Name = "Uk"
                        },
                        new
                        {
                            CountryId = 4,
                            Name = "China"
                        },
                        new
                        {
                            CountryId = 5,
                            Name = "Japan"
                        },
                        new
                        {
                            CountryId = 6,
                            Name = "France"
                        },
                        new
                        {
                            CountryId = 7,
                            Name = "Italia"
                        });
                });

            modelBuilder.Entity("Assignment1.Models.Customers", b =>
                {
                    b.Property<int>("CustomersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomersId");

                    b.HasIndex("CountryId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomersId = 1,
                            Address = "200 King",
                            City = "Toronto",
                            CountryId = 1,
                            Email = "thihoangtram.tran@georgebrown.ca",
                            FirstName = "Kaitlyn",
                            LastName = "Anthoni",
                            Phone = "4167221285",
                            PostalCode = "M6J 0B3",
                            State = "Ontario"
                        },
                        new
                        {
                            CustomersId = 2,
                            Address = "286 King",
                            City = "Atlanta",
                            CountryId = 3,
                            Email = "",
                            FirstName = "Ania ",
                            LastName = "Irvin",
                            Phone = "4167221285",
                            PostalCode = "M6J 111",
                            State = "Quesbec"
                        },
                        new
                        {
                            CustomersId = 3,
                            Address = "286 Richmond Hill",
                            City = "Kingdom",
                            CountryId = 5,
                            Email = "abc@gmail.com",
                            FirstName = "Kendall ",
                            LastName = "Maya",
                            Phone = "4167123456",
                            PostalCode = "M3r 7Y6",
                            State = "Ottawa"
                        });
                });

            modelBuilder.Entity("Assignment1.Models.Incidents", b =>
                {
                    b.Property<int>("IncidentsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CustomersId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DayClose")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DayOpen")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("TechniciansId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IncidentsId");

                    b.HasIndex("CustomersId");

                    b.HasIndex("ProductsId");

                    b.HasIndex("TechniciansId");

                    b.ToTable("Incidents");

                    b.HasData(
                        new
                        {
                            IncidentsId = 1,
                            CustomersId = 1,
                            DayClose = new DateTime(2021, 7, 19, 21, 10, 26, 965, DateTimeKind.Local).AddTicks(5018),
                            DayOpen = new DateTime(2021, 7, 19, 21, 10, 26, 965, DateTimeKind.Local).AddTicks(4782),
                            Description = "Got 100 for this assignment",
                            ProductsId = 1,
                            TechniciansId = 1,
                            Title = "Congratulation !"
                        },
                        new
                        {
                            IncidentsId = 2,
                            CustomersId = 2,
                            DayClose = new DateTime(2021, 7, 19, 21, 10, 26, 965, DateTimeKind.Local).AddTicks(5488),
                            DayOpen = new DateTime(2021, 7, 19, 21, 10, 26, 965, DateTimeKind.Local).AddTicks(5487),
                            Description = "Some errors happen !",
                            ProductsId = 2,
                            TechniciansId = 2,
                            Title = "Could not install"
                        },
                        new
                        {
                            IncidentsId = 3,
                            CustomersId = 3,
                            DayClose = new DateTime(2021, 7, 19, 21, 10, 26, 965, DateTimeKind.Local).AddTicks(5506),
                            DayOpen = new DateTime(2021, 7, 19, 21, 10, 26, 965, DateTimeKind.Local).AddTicks(5505),
                            Description = "Application still run but need to fix some error",
                            ProductsId = 3,
                            TechniciansId = 3,
                            Title = "Error Launching program"
                        });
                });

            modelBuilder.Entity("Assignment1.Models.Products", b =>
                {
                    b.Property<int>("ProductsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Rdate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductsId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductsId = 1,
                            Code = "LEAG10",
                            Name = "League Scheduler 1.0",
                            Price = 4.99m,
                            Rdate = new DateTime(2021, 7, 19, 21, 10, 26, 963, DateTimeKind.Local).AddTicks(9851)
                        },
                        new
                        {
                            ProductsId = 2,
                            Code = "LEAGD10",
                            Name = "League Scheduler Deluxe 1.0",
                            Price = 7.99m,
                            Rdate = new DateTime(2021, 7, 19, 21, 10, 26, 964, DateTimeKind.Local).AddTicks(8372)
                        },
                        new
                        {
                            ProductsId = 3,
                            Code = "DRAFT10",
                            Name = "Draft Manager 10",
                            Price = 4.99m,
                            Rdate = new DateTime(2021, 7, 19, 21, 10, 26, 964, DateTimeKind.Local).AddTicks(8450)
                        });
                });

            modelBuilder.Entity("Assignment1.Models.Technicians", b =>
                {
                    b.Property<int>("TechniciansId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("TechniciansId");

                    b.ToTable("Technicians");

                    b.HasData(
                        new
                        {
                            TechniciansId = 1,
                            Email = "thihoangtram.tran@georgebrown.ca",
                            Name = "Wynne Tran",
                            Phone = "4167221285"
                        },
                        new
                        {
                            TechniciansId = 2,
                            Email = "kiani.forough@georgebrown.ca",
                            Name = "Forough Kiani",
                            Phone = "4167686868"
                        },
                        new
                        {
                            TechniciansId = 3,
                            Email = "matias.herter@georgebrown.ca",
                            Name = "Matias Herter",
                            Phone = "4167999888"
                        });
                });

            modelBuilder.Entity("Assignment1.Models.Customers", b =>
                {
                    b.HasOne("Assignment1.Models.Country", "nation")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("nation");
                });

            modelBuilder.Entity("Assignment1.Models.Incidents", b =>
                {
                    b.HasOne("Assignment1.Models.Customers", "CustomerName")
                        .WithMany()
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment1.Models.Products", "ProductName")
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment1.Models.Technicians", "TechnicianName")
                        .WithMany()
                        .HasForeignKey("TechniciansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerName");

                    b.Navigation("ProductName");

                    b.Navigation("TechnicianName");
                });
#pragma warning restore 612, 618
        }
    }
}
