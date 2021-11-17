using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentPortal.Services.ViewModels
{
    public class LoginVM
    {
        [DisplayName("Username")]
        [Required]
        public string Username { get; set; }

        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        //public string ReturnUrl { get; set; }

        public bool RememberMe { get; set; }
    }
}
