using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentPortal.Model;

namespace StudentPortal.IDataAccessLayer
{
    public interface IStudentRepository
    {
        void GetStudent(int id);
        Student GetStudent();
        void InsertStd();
        void UpdateStd();
        void DeleteeStd();
    }
}
