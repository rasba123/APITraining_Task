using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentPortal.Model.Models
{
    public class StudentAddress
    {   [Key]
        public int StandardId { get; set; }

        //[Key, Column(Order = 0)]
        public int StudentId { get; set; }            
        public string StudentAddress1 { get; set; }
        public string StudentAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Student Student { get; set; }
      
    }
}
