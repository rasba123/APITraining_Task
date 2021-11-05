using StudentPortal.Model;
using StudentPortal.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal.IBusinessServiceLayer
{
    public interface IStudentService
    {

        IEnumerable<StudentViewModel> Get();
        StudentViewModel GetById(int id);
        bool Update(StudentViewModel studentViewModel);
        bool Insert(StudentViewModel student);
        void Delete(int id);
        IEnumerable<StudentViewModel> GetStudentAddress();
        StudentViewModel GetbyName(string name);
    }
}
