using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentPortal.Model.Models
{
     public class Users
    {
        [Key]
        public int ID { get; set; }
       
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
