using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebGentle_BookStore.Models
{
    public class SignupUserModel
    {
        [Required(ErrorMessage="Please Enter Your Email")]
        [Display(Name= "Email Address")]
        [EmailAddress(ErrorMessage ="Please Enter Valid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter a strong Password")]
        [Compare("ConfirmPassword", ErrorMessage ="Password doesn't Match")]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }




        [Required(ErrorMessage = "Please Confirm Your Password")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
