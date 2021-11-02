using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Model.GenericRepository.IRepository
{
    public interface IEFRepositoryReadOnly<TEntity> where TEntity : class
    {
        TEntity GetById(object id);


        IEnumerable<TEntity> Get();
          
        //void GetStudentAddress<TEntity>();
    }
}
