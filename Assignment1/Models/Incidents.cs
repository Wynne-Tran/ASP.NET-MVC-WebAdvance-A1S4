using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Incidents
    {
        [Key]
        public int IncidentsId { get; set; }
        [Required]
        public string Title { get; set; }

        
        public int CustomersId { get; set; }
        public Customers CustomerName { get; set; }

        
        public int ProductsId { get; set; }
        public Products ProductName { get; set; }

        [Required]
        public string Description { get; set; }

        public int TechniciansId { get; set; }
        public Technicians TechnicianName { get; set; }

        
        public DateTime DayOpen { get; set; } 
        [Required]
        public DateTime DayClose { get; set; } = DateTime.Now;

        
    }
}
