using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class ProductsContext:DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        {
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Technicians> Technicians { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Incidents> Incidents { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(
                new Products
                {
                    ProductsId = 1,
                    Code = "LEAG10",
                    Name = "League Scheduler 1.0",
                    Price = 4.99M,
                    Rdate = DateTime.Now
                }
                );
            modelBuilder.Entity<Products>().HasData(
                new Products
                {
                    ProductsId = 2,
                    Code = "LEAGD10",
                    Name = "League Scheduler Deluxe 1.0",
                    Price = 7.99M,
                    Rdate = DateTime.Now
                }
                );
            modelBuilder.Entity<Products>().HasData(
                new Products
                {
                    ProductsId = 3,
                    Code = "DRAFT10",
                    Name = "Draft Manager 10",
                    Price = 4.99M,
                    Rdate = DateTime.Now
                }
                );



            modelBuilder.Entity<Technicians>().HasData(
                new Technicians
                {
                    TechniciansId = 1,
                    Name = "Wynne Tran",
                    Email = "thihoangtram.tran@georgebrown.ca",
                    Phone = "4167221285"
                }
                );

            modelBuilder.Entity<Technicians>().HasData(
                new Technicians
                {
                    TechniciansId = 2,
                    Name = "Forough Kiani",
                    Email = "kiani.forough@georgebrown.ca",
                    Phone = "4167686868"
                }
                );

            modelBuilder.Entity<Technicians>().HasData(
                new Technicians
                {
                    TechniciansId = 3,
                    Name = "Matias Herter",
                    Email = "matias.herter@georgebrown.ca",
                    Phone = "4167999888"
                }
                );

            modelBuilder.Entity<Customers>().HasData(
                new Customers
                {
                    CustomersId = 1,
                    FirstName = "Kaitlyn",
                    LastName = "Anthoni",
                    Address = "200 King",
                    City = "Toronto",
                    State = "Ontario",
                    PostalCode = "M6J 0B3",
                    CountryId = 1,
                    Email = "thihoangtram.tran@georgebrown.ca",
                    Phone = "4167221285"
                }
                );

            modelBuilder.Entity<Customers>().HasData(
                new Customers
                {
                    CustomersId = 2,
                    FirstName = "Ania ",
                    LastName = "Irvin",
                    Address = "286 King",
                    City = "Atlanta",
                    State = "Quesbec",
                    PostalCode = "M6J 111",
                    CountryId = 3,
                    Email = "",
                    Phone = "4167221285"
                }
                );

            modelBuilder.Entity<Customers>().HasData(
                new Customers
                {
                    CustomersId = 3,
                    FirstName = "Kendall ",
                    LastName = "Maya",
                    Address = "286 Richmond Hill",
                    City = "Kingdom",
                    State = "Ottawa",
                    PostalCode = "M3r 7Y6",
                    CountryId = 5,
                    Email = "abc@gmail.com",
                    Phone = "4167123456"
                }
                );

            modelBuilder.Entity<Country>().HasData(
                new Country { CountryId = 1, Name = "Canada" },
                new Country { CountryId = 2, Name = "USA" },
                new Country { CountryId = 3, Name = "Uk" },
                new Country { CountryId = 4, Name = "China" },
                new Country { CountryId = 5, Name = "Japan" },
                new Country { CountryId = 6, Name = "France" },
                new Country { CountryId = 7, Name = "Italia" }
            );

            modelBuilder.Entity<Incidents>().HasData(
                new Incidents
                {
                    IncidentsId = 1,
                    CustomersId = 1,
                    ProductsId = 1,
                    Title = "Congratulation !",
                    Description = "Got 100 for this assignment",
                    TechniciansId = 1,
                    DayOpen = DateTime.Now,
                    DayClose = DateTime.Now
                   
                }
                );
            modelBuilder.Entity<Incidents>().HasData(
                new Incidents
                {
                    IncidentsId = 2,
                    CustomersId = 2,
                    ProductsId = 2,
                    Title = "Could not install",
                    Description = "Some errors happen !",
                    TechniciansId = 2,
                    DayOpen = DateTime.Now,
                    DayClose = DateTime.Now

                }
                );

            modelBuilder.Entity<Incidents>().HasData(
                new Incidents
                {
                    IncidentsId = 3,
                    CustomersId = 3,
                    ProductsId = 3,
                    Title = "Error Launching program",
                    Description = "Application still run but need to fix some error",
                    TechniciansId = 3,
                    DayOpen = DateTime.Now,
                    DayClose = DateTime.Now

                }
                );
        }


    }
}
