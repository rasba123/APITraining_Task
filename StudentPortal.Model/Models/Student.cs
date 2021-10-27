using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentPortal.Model.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        
        public string StudentName { get; set; }
        public string StudentPhone { get; set; }

        public ICollection<Enrollment> Enrollment { get; set; }
    }
}

