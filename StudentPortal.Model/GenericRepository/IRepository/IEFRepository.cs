using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Model.GenericRepository.IRepository
{
     public interface IEFRepository<TEntity>:IEFRepositoryReadOnly<TEntity> where TEntity : class
    {
        bool Create(TEntity entity);

        bool Update(TEntity entity);

        void Delete(int id);
  
      
    }
}
