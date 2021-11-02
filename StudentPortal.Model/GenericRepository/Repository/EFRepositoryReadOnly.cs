using Microsoft.EntityFrameworkCore;
using StudentPortal.Model.Context;
using StudentPortal.Model.GenericRepository.IRepository;
using StudentPortal.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace StudentPortal.Model.GenericRepository.Repository
{
    public class EFRepositoryReadOnly<TEntity> : IEFRepositoryReadOnly<TEntity> where TEntity : class
    {
        private  StudentDbContext _dbContext;
        //private StudentDbContext context;

        public EFRepositoryReadOnly(StudentDbContext context)
        {
            this._dbContext = context;
        }

        public EFRepositoryReadOnly(StudentDbContext dbContext, object getById)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<TEntity> Get<TEntity>() where TEntity : class
        {
            //var studAddr = context.Set<StudentAddress>().ToList();
          
            return _dbContext.Set<TEntity>().ToList();
        }

        public TEntity GetById<TEntity>(object id) where TEntity : class
        {
           return _dbContext.Set<TEntity>().Find(id);
        }
    }
}
