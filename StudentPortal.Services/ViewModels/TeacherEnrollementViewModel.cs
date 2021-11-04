using StudentPortal.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Services.ViewModels
{
    public class TeacherEnrollementViewModel
    {
        public Teacher Teacher { get; set; }
        public Enrollment Enrollment { get; set; }
    }
}
