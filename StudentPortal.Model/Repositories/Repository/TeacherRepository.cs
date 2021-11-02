using StudentPortal.Model.Context;
using StudentPortal.Model.GenericRepository.Repository;
using StudentPortal.Model.Models;
using StudentPortal.Model.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;

namespace StudentPortal.Model.Repositories.Repository
{
    public class TeacherRepository: EFRepositoryReadOnly<Teacher>,ITeacherRepository
    {
        private readonly StudentDbContext _dbContext;
        public TeacherRepository(StudentDbContext context) : base(context)
        {
            _dbContext = context;
        }

     

        public IEnumerable<object> GetTeacherCourses()
        {
            var list = _dbContext.Teacher.Join(_dbContext.Enrollment, teacher => teacher.TeacherId,
                      enrolment => enrolment.TeacherId, (teacher, enrolment) => new { Teacher = teacher, Enrollment = enrolment }).ToList();
           
            return list;
           
        }
        public IEnumerable<Teacher> GetTeacher()
        {
            var st = Get();
            return st;
        }

        }
}
