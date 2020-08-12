using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucia_Restaurant.Dtos
{
    public class User
    {
        [Key]
        private int UserID { get; set; }
        
        [StringLength(100)]
        [MaxLength(100,ErrorMessage = "Name cannot be longer than 100 characters.")]
        [Display(Name="Name")]
        [Required(ErrorMessage ="Please enter name .")]
        private string  Name { get; set; }
        
        [StringLength(50)]
        [MaxLength(50,ErrorMessage ="Street cannot be longer than 50 characters.")]
        [Display(Name="Street")]
        [Required(ErrorMessage ="Please enter Street .")]
        private string  Street { get; set; }
        [StringLength(50)]
        [Display(Name ="Suburb")]
        [Required(ErrorMessage ="Please enter suburb .")]
        private string Suburb { get; set; }
        [StringLength(50)]
        [Display(Name = "Country")]
        [Required(ErrorMessage = "Please enter Country .")]
        private string Country  { get; set; }
        [StringLength(50)]
        [Display(Name = "PostCode")]
        [Required(ErrorMessage = "Please enter PostCode .")]
        private string  PostCode { get; set; }
        [StringLength(50)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please enter Phone Number .")]
        private string Phone_Number { get; set; }
        [Display(Name = "Restaurant type")]
        [Required(ErrorMessage = "Please enter Phone Type .")]
        private byte Type { get; set; }
        [StringLength(50)]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter Email .")]
        private string Email { get; set; }
        [StringLength(50)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter Password .")]
        private string  Password { get; set; }
        [StringLength(50)]
        [Display(Name = "SignUp_on")]
        [Required(ErrorMessage = "Please enter SignUp_on .")]
        private string  SignUp_on { get; set; }
    }
}
