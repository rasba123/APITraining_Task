using StudentPortal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal.IBusinessServiceLayer
{
    public interface IStudentService<T> 
    {
        IEnumerable<T> Get();
        T GetById(int id);
        bool Update(T studentViewModel);
       bool Insert(T student);
        void Delete(int id);
    }
}
