
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

namespace StudentPortal.BusinessServiceLayer
{
    public class StudentService: IStudentService
    {
        private readonly IMapper _mapper;
        private IStudentRepository _StudentRepository;
        public StudentService(IMapper mapper, IStudentRepository studentRepository)
        {
            _mapper = mapper;
            this._StudentRepository = studentRepository;
        }
 
        public IEnumerable<StudentViewModel> GetStudents() 
        {
            var st = _StudentRepository.GetStudents();
            var Viewmodel = _mapper.Map<IEnumerable<StudentViewModel>>(st);
             return Viewmodel;
        }
        public StudentViewModel GetStudent(int id)
        {
            var st = _StudentRepository.GetStudent(id);
            var Viewmodel = _mapper.Map<StudentViewModel>(st);
            return Viewmodel;
        }

        public bool UpdateStd(StudentViewModel student)
        {
            var model = _mapper.Map<StudentDTO>(student);
            bool Success = _StudentRepository.UpdateStd(model);          
            return Success;
        }
        public bool InsertStd(StudentViewModel student)
        {
            var model = _mapper.Map<StudentDTO>(student);
            bool Success = _StudentRepository.InsertStd(model);
            return Success;
        }

        public void DeleteStd(int id)
        {
            _StudentRepository.DeleteStd(id);
          
        }
    
    }
}
