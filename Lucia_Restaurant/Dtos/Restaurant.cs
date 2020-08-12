using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucia_Restaurant.Dtos
{
    public class Restaurant
    {
        [Key]
        private int Id { get; set; }
        [Required(ErrorMessage = "Please Enter  Name .")]
        [StringLength(100)]
        [MaxLength(100, ErrorMessage = "Name cannot be longer than 50 characters.")]
        private string Name { get; set; }
        [Required(ErrorMessage = "Please Enter  Street .")]
        [StringLength(100)]
        [MaxLength(100, ErrorMessage = "Street cannot be longer than 50 characters.")]
        private string Street { get; set; }
        [Required(ErrorMessage = "Please Enter  Suburb .")]
        [StringLength(50)]
        [MaxLength(50, ErrorMessage = "Suburb cannot be longer than 50 characters.")]
        private string Suburb { get; set; }
        [Required(ErrorMessage = "Please Enter  Country .")]
        [StringLength(50)]
        [MaxLength(50, ErrorMessage = "Country cannot be longer than 50 characters.")]
        private string Country { get; set; }
        [Required(ErrorMessage = "Please Enter  PostCode .")]
        [StringLength(50)]
        [MaxLength(50, ErrorMessage = "PostCode cannot be longer than 50 characters.")]
        private string PostCode { get; set; }
        [Required(ErrorMessage = "Please Enter  Phone_Number .")]
        [StringLength(50)]
        [MaxLength(50, ErrorMessage = "Phone_Number cannot be longer than 50 characters.")]
        [Display(Name="Phone_Number")]
        private string  Phone_Number { get; set; }
    }
}
