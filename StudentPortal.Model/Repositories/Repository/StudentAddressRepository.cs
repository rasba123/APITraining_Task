using StudentPortal.Model.Context;
using StudentPortal.Model.GenericRepository.Repository;
using StudentPortal.Model.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Model.Repositories.Repository
{
    class StudentAddressRepository : EFRepositoryReadOnly, IStudentAddressRepository
    {
        private readonly StudentDbContext _dbContext;
        public StudentAddressRepository(StudentDbContext context) : base(context)
        {
            _dbContext = context;
        }
    }
}
