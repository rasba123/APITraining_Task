using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Model.Models
{
   public class Course
    {
        [Key]
        public int CourseId { get; set; }
       
        public string CourseName { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; }
    }
}
