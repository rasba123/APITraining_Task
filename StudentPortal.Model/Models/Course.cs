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
        public string Location { get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }
}
