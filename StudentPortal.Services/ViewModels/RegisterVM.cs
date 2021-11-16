using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentPortal.Services.ViewModels
{
  public class RegisterVM
    {
        [Required]
        public int StudentId { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password didnt match")]
        public string ConfirmPassword { get; set; }

    }
}
