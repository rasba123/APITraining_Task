using StudentPortal.IDataAccessLayer;
using StudentPortal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal.DataAccessLayer
{

    public class StudentRepository : ICRUDRepository<StudentDTO>
    {
        private List<StudentDTO> StudentList;
        public StudentRepository()
        {

            StudentList = new List<StudentDTO>()
            {
                new StudentDTO() { Id = 88, Date = "10/21/2021" , FirstName = "Rasba" , SecondName ="Afzal" , Percentage = 70},
                  new StudentDTO() { Id = 98, Date = "10/21/2021" , FirstName = "Rasba" , SecondName ="Afzal" , Percentage = 70}
            };
        }

        public void Delete(int id)
        {
            var itemToRemove = StudentList.Where(r => r.Id == id).FirstOrDefault();
            StudentList.Remove(itemToRemove);
        }

        public IEnumerable<StudentDTO> Get()
        {
            return StudentList;
        }

        public StudentDTO GetById(int id)
        {
            return StudentList.Where(x => x.Id == id).FirstOrDefault();
        }
    
        public bool Insert(StudentDTO student)
        {
            bool Success = false;
            try
            {
                StudentList.Add(new StudentDTO { Id = student.Id, Date = student.Date, FirstName = student.FirstName, SecondName = student.SecondName, Percentage = student.Percentage });

                Success = true;
            }
            catch
            {
                Success = false;
            }

            return Success;
        }
        public bool Update(StudentDTO student)
        {
            bool Success = false;
            try
            {
                foreach (var item in StudentList.Where(w => w.Id == student.Id))
                {
                    item.Percentage = student.Percentage;
                    item.Date = student.Date;
                    item.FirstName = student.FirstName;
                    item.SecondName = student.SecondName;
                }
                Success = true;
            }
            catch
            {
                Success = false;
            }
            return Success;
        }

    }
}
