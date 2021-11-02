using StudentPortal.Model.Context;
using StudentPortal.Model.GenericRepository.Repository;
using StudentPortal.Model.Models;
using StudentPortal.Model.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Model.Repositories.Repository
{
   public class EnrollmentRepository: EFRepositoryReadOnly<Enrollment>,IEnrollmentRepository
    {
        private readonly StudentDbContext _dbContext;
        public EnrollmentRepository(StudentDbContext context) : base(context)
        {
            _dbContext = context;
        }
    }
}
