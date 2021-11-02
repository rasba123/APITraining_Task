﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Model.GenericRepository.IRepository
{
     public interface IEFRepository<TEntity>:IEFRepositoryReadOnly<TEntity> where TEntity : class
    {
        bool Create<TEntity>(TEntity entity)
      where TEntity : class;
        bool Update<TEntity>(TEntity entity)
    where TEntity : class;
        void Delete<TEntity>(int id)
    where TEntity : class;
      
    }
}
