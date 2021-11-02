using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentPortal.Model.Models
{
    public class Enrollment
    {
        //[Key]
        //public int Id { get; set; }
     //   [Key, Column(Order = 0)]
        public int CourseId { get; set; }
        //[Key, Column(Order = 1)]
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnrollmentID { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
