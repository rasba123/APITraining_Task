using StudentPortal.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Model.Repositories.IRepository
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetTeacherCourses();
    }    
}
