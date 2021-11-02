using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Model.GenericRepository.IRepository
{
    public interface IEFRepositoryReadOnly<TEntity> where TEntity : class
    {
        TEntity GetById<TEntity>(object id)
           where TEntity : class;

        IEnumerable<TEntity> Get<TEntity>()
          where TEntity : class;
        //void GetStudentAddress<TEntity>();
    }
}
