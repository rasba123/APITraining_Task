using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentPortal.Model.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public int StandardId { get; set; }
        public string TeacherType { get; set; }
        //  public Course Course { get; set; }
        public ICollection<Standard> Standards { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; }
    }
}
