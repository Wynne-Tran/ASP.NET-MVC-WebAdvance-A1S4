
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Technicians
    {

        [Key]
        public int TechniciansId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

    }
}
