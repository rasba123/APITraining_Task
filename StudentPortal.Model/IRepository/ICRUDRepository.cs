using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentPortal.Model;

namespace StudentPortal.IDataAccessLayer
{
    public interface ICRUDRepository<T>
    {
        IEnumerable<T> Get();
        T GetById(int id);
        bool Update(T studentViewModel);
        bool Insert(T student);
        void Delete(int id);
    }
}
