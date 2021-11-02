using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentPortal.Model.Models
{
    public class Standard
    {
        [Key]
        public int StandardId { get; set; }
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StandardCode { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public string StandardName { get; set; }
        public string StandardDesc { get; set; }
        public Student Student { get; set; }
       public Teacher Teacher { get; set; }
    }
}
