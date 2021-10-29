using StudentPortal.Model.Context;
using StudentPortal.Model.GenericRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace StudentPortal.Model.GenericRepository.Repository
{
    public class EFRepositoryReadOnly : IEFRepositoryReadOnly
    {
        private readonly StudentDbContext _dbContext;
        public EFRepositoryReadOnly(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<TEntity> Get<TEntity>() where TEntity : class
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public TEntity GetById<TEntity>(object id) where TEntity : class
        {
           return _dbContext.Set<TEntity>().Find(id);
        }
    }
}
