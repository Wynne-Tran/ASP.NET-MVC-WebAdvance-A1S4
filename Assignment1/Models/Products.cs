using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Products
    {
        [Key]
        public int ProductsId { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0, 1000000, ErrorMessage = "Price have to larger than 0.00")]
        public decimal Price { get; set; } = 0.00M;
        [Required]
        public DateTime Rdate { get; set; } = DateTime.Now;


    }
}
