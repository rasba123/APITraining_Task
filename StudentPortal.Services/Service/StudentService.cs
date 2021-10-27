
using StudentPortal.DataAccessLayer;
using StudentPortal.IBusinessServiceLayer;
using StudentPortal.IDataAccessLayer;
using StudentPortal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Newtonsoft.Json;
using StudentPortal.Model.Models;

namespace StudentPortal.BusinessServiceLayer
{
    public class StudentService: IStudentService
    {
        private readonly IMapper _mapper;
        private ICRUDRepository<Student> _StudentRepository;
        public StudentService(IMapper mapper, ICRUDRepository<Student> studentRepository)
        {
            _mapper = mapper;
            this._StudentRepository = studentRepository;
        }
       //public IEnumerable<Student> GetST()

       // { 
       //     var st = _StudentRepository.Get();
       // var Viewmodel = _mapper.Map<Student>(st);
       //     yield return Viewmodel;
       // }
        public IEnumerable<StudentViewModel> Get()
        {
            var st = _StudentRepository.Get();
            var Viewmodel = _mapper.Map<IEnumerable<StudentViewModel>>(st);
            return Viewmodel;
        }  
        public bool Update(StudentViewModel student)
        {
            var model = _mapper.Map<Student>(student);
            bool Success = _StudentRepository.Update(model);
            return Success;
        }

        public bool Insert(StudentViewModel student)
        {
            var model = _mapper.Map<Student>(student);
            bool Success = _StudentRepository.Insert(model);
            return Success;
        }

        public StudentViewModel GetById(int id)
        {
            var st = _StudentRepository.GetById(id);
            var Viewmodel = _mapper.Map<StudentViewModel>(st);
            return Viewmodel;
        }

        public void Delete(int id)
        {
            _StudentRepository.Delete(id);
        }

       
    }
}
