using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucia_Restaurant.Dtos
{
    public class Order
    {
        [Key]
        private int Id { get; set; }
        [Required(ErrorMessage ="Please enter the Total_coast")]
        [Display(Name ="Total_Cost")]
        private int Total_Cost  { get; set; }
        [StringLength(100)]
        [MaxLength(100,ErrorMessage ="Please enter comment")]
        [Display(Name = "Comment")]
        private string Comment { get; set; }
    }
}
