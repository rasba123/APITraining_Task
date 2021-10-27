using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentPortal.Model;
using StudentPortal.Model.Models;

namespace StudentPortal.IDataAccessLayer
{
    public interface ICRUDRepository<T>
    {
        //Student GetById(int id);
        //IEnumerable<Student> Get();
        //bool Insert(Student student);
        //bool Update(Student student);
        //void Delete(int id);
        IEnumerable<T> Get();
        T GetById(int id);
        bool Update(T studentViewModel);
        bool Insert(T student);
        void Delete(int id);
       
    }
}
