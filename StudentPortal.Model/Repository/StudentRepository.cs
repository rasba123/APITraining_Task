using StudentPortal.IDataAccessLayer;
using StudentPortal.Model;
using StudentPortal.Model.Context;
using StudentPortal.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal.DataAccessLayer
{

    public class StudentRepository : ICRUDRepository<Student>
    {
        //private List<StudentDTO> StudentList;
        private readonly StudentDbContext _dbContext;
        public StudentRepository(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
            //StudentList = new List<StudentDTO>()
            //{
            //   // new StudentDTO() { Id = 88, Dated = "10/21/2021" , FirstName = "Rasba" , SecondName ="Afzal" , Percentage = "70"},
            //     // new StudentDTO() { Id = 98, Dated = "10/21/2021" , FirstName = "Rasba" , SecondName ="Afzal" , Percentage = "70"}
            //};
        }
       
        public void Delete(int id)
        {
            var result = _dbContext.Student.Where(x => x.StudentId == id);
            if (result != null)
            {
                _dbContext.Remove(_dbContext.Student.Single(a => a.StudentId == id));
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<Student> Get()
        {
            return _dbContext.Student.ToList();
           // return StudentList;
        }

        public Student GetById(int id)
        {
            return _dbContext.Student.Where(x => x.StudentId == id).FirstOrDefault();
        }
    
        public bool Insert(Student student)
        {
            bool Success = false;
            try
            {
                var std = new Student()
                {
                    //StudentId = student.StudentId,
                    StudentName = student.StudentName,
                    StudentPhone = student.StudentPhone
                };
                _dbContext.Student.Add(std);

                _dbContext.SaveChanges();
                //StudentList.Add(new StudentDTO { Id = student.Id, Dated = student.Dated, FirstName = student.FirstName, SecondName = student.SecondName, Percentage = student.Percentage });

                Success = true;
            }
            catch
            {
                Success = false;
            }

            return Success;
        }
        public bool Update(Student student)
        {
            bool Success = false;
            try
            {
                var result = _dbContext.Student.Where(x => x.StudentId == student.StudentId);
                if (result != null)
                {
                    _dbContext.Update(student);
                    _dbContext.SaveChanges();
                    Success = true;
                }
                //foreach (var item in StudentList.Where(w => w.Id == student.Id))
                //{
                //    StudentId = student.StudentId,
                //StudentName = student.StudentName,
                //StudentPhone = student.StudentPhone
                ////    item.Percentage = student.Percentage;
                ////    item.Dated = student.Dated;
                ////    item.FirstName = student.FirstName;
                ////    item.SecondName = student.SecondName;
                //}
               
            }
            catch
            {
                Success = false;
            }
            return Success;
        }

    }
}
