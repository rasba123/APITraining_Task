using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentPortal.Services.ViewModels
{
  public class RegisterVM
    {
    
        public int ID{ get; set; }
        [Required]
        //[DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        //[DataType(DataType.Password)]
        //[Compare("Password", ErrorMessage ="Password didnt match")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Username { get; set; }
        [EmailAddress]
        public string Email { get; set; }

    }
}
