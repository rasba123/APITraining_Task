﻿using StudentPortal.Model.Context;
using StudentPortal.Model.GenericRepository.IRepository;
using StudentPortal.Model.GenericRepository.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using StudentPortal.Model.Models;
using StudentPortal.Model.Repositories.IRepository;

namespace StudentPortal.Model.Repository
{
    public class StudentRepository : EFRepositoryReadOnly<Student>, IStudentRepository
    {
        private readonly StudentDbContext _dbContext;
        public StudentRepository(StudentDbContext context) : base(context)
        {
            _dbContext = context;
        }

        public IEnumerable<Student> GetStudentAddress()
        {
            return _dbContext.Set<Student>()
                         .Include("StudentAddress").ToList();
        }

        public Student GetbyName(string name)
        {
            var list = (from s in _dbContext.Student
                        where s.StudentName == name
                        select new Student
                        {
                            StudentId = s.StudentId,
                            StudentName = s.StudentName,
                            StudentPhone = s.StudentPhone,
                            StudentAddress = s.StudentAddress
                        }).FirstOrDefault();
            return list;
           
                        
        }
    }
}
