using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Model.Models
{
    public class TeacherEnrollment
    {
        public Teacher Teacher { get; set; }
        public Enrollment Enrollment { get; set; }
    }
}
