using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Model.Models
{
    public class StandardViewModel
    {

        public int StandardId { get; set; }
        public int StandardCode { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public string StandardName { get; set; }
        public string StandardDesc { get; set; }
    }
}
