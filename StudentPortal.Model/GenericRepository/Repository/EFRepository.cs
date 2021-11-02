using Microsoft.EntityFrameworkCore;
using StudentPortal.Model.Context;
using StudentPortal.Model.GenericRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;


namespace StudentPortal.Model.GenericRepository.Repository
{
    public class EFRepository<TEntity>: EFRepositoryReadOnly<TEntity>,IEFRepository<TEntity> where TEntity : class

    {
        private readonly StudentDbContext _dbContext;
        public EFRepository(StudentDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }

           public virtual bool Create<TEntity>(TEntity entity) where TEntity : class
        {
            _dbContext.Set<TEntity>().Add(entity);
            Save();
            return true;
        }

        public bool Update<TEntity>(TEntity entity) where TEntity : class
        {
            _dbContext.Set<TEntity>().Update(entity);
            Save();
            return true;
        }
        public virtual void Save()
        {
            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
              
            }
        }
        public virtual void Delete<TEntity>(int id)
          where TEntity : class
        {
            TEntity entity = _dbContext.Set<TEntity>().Find(id);
            Delete(entity);
        }

        public virtual void Delete<TEntity>(TEntity entity)
            where TEntity : class
        {
            var dbSet = _dbContext.Set<TEntity>();
            if (_dbContext.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }


    }
}
