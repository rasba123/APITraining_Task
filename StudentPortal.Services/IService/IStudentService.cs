using StudentPortal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal.IBusinessServiceLayer
{
    public interface IStudentService 
    {
        IEnumerable<StudentViewModel> GetStudents();
        StudentViewModel GetStudent(int id);
        bool UpdateStd(StudentViewModel studentViewModel);
       bool InsertStd(StudentDTO student);
        void DeleteStd(int id);
    }
}
