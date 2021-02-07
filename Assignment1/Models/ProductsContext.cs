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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(
                new Products
                {
                    ProductsId = 1,
                    Code = "A001",
                    Name = "Wynne",
                    Price = 100.89M,
                    Rdate = DateTime.Now
                }
                );

            modelBuilder.Entity<Technicians>().HasData(
                new Technicians
                {
                    TechniciansId = 1,
                    Name = "Wynne",
                    Email = "thihoangtram.tran@georgebrown.ca",
                    Phone = "4167221285"
                }
                );
        }


    }
}
