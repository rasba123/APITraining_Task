using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Model.Models
{
   public class CourseViewModel
    {
        public int CourseId { get; set; }    
        public string CourseName { get; set; }
        public string Location { get; set; }
        public ICollection<EnrollmentViewModel> Enrollment { get; set; }
    }
}
