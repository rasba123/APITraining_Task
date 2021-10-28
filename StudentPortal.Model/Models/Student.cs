using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentPortal.Model.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int StudentCode { get; set; }
        public string StudentName { get; set; }
        public int StandardId { get; set; }
        public string StudentPhone { get; set; }
        public ICollection<Standard> Standards { get; set; }
        public ICollection<StudentAddress> StudentAddress { get; set; }
        public ICollection<Course> Course { get; set; }
    }
}

