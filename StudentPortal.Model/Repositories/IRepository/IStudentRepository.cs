using StudentPortal.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Model.Repositories.IRepository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudentAddress();
        Student GetbyName(string name);
        IEnumerable<Student> StudentGroupby();
    }
}
