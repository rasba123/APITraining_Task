using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentPortal.Model;

namespace StudentPortal.IDataAccessLayer
{
    public interface IStudentRepository
    {
        StudentDTO GetStudent(int id);
        IEnumerable<StudentDTO> GetStudents();
        bool InsertStd(StudentDTO student);
        bool UpdateStd(StudentDTO student);
        void DeleteStd(int id);
    }
}
