using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Model.Models
{
  public class EnrollTeacher
    {
        public int CourseId { get; set; }
   
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
     
        public int EnrollmentID { get; set; }
        public int TeacherId { get; set; }
        public string CourseName { get; set; }
        public string Location { get; set; }
    }
}
