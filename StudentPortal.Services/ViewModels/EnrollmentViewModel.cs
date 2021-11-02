using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Model.Models
{
    public class EnrollmentViewModel
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public int EnrollmentID { get; set; }
        public int TeacherId { get; set; }
    }
}
