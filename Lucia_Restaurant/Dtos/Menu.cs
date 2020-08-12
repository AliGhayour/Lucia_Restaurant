using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucia_Restaurant.Dtos
{
    public class Menu
    {
        [Key]
        private int Menu_id { get; set; }
        [Required(ErrorMessage = "Please Enter  Name .")]
        [StringLength(100)]
        [MaxLength(100, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Display(Name="Name")]
        private string Name { get; set; }
        [Required(ErrorMessage = "Please Enter  Price .")]
        [Display(Name="Price")]
        private int  Price { get; set; }
        [Required(ErrorMessage = "Please Enter  Description .")]
        [StringLength(100)]
        [MaxLength(100, ErrorMessage = "Description cannot be longer than 100 characters.")]
        [Display(Name="Description")]
        private string  Description { get; set; }
        [Required(ErrorMessage = "Please Enter  Image .")]
        [StringLength(100)]
        [MaxLength(100, ErrorMessage = "Image cannot be longer than 100 characters.")]
        [Display(Name="Image")]
        private string  Image { get; set; }

    }
}
