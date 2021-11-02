using StudentPortal.Model.Context;
using StudentPortal.Model.GenericRepository.Repository;
using StudentPortal.Model.Models;
using StudentPortal.Model.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Model.Repositories.Repository
{
    class CourseRepository: EFRepositoryReadOnly<Course>,ICourseRepository
    {
        private readonly StudentDbContext _dbContext;
        public CourseRepository(StudentDbContext context) : base(context)
        {
            _dbContext = context;
        }
    }
}
