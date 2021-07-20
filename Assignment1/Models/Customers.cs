using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Customers
    {
        [Key]
        public int CustomersId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string PostalCode { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public int CountryId { get; set; }
        public Country nation { get; set; }

        public string Name
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }

    }
}
