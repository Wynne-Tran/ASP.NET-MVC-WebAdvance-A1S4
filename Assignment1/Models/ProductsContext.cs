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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(
                new Products
                {
                    ProductsId = 1,
                    Code = "A001",
                    Name = "Wynne",
                    Price = 100.5,
                    Rdate = DateTime.Now
                },
                new Products
                {
                    ProductsId = 2,
                    Code = "A002",
                    Name = "Hoang",
                    Price = 10.5,
                    Rdate = DateTime.Now
                }
                );
        }


    }
}
