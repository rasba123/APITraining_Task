
using StudentPortal.IBusinessServiceLayer;
using StudentPortal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Newtonsoft.Json;
using StudentPortal.Model.Models;
using StudentPortal.Model.GenericRepository.IRepository;
using StudentPortal.Model.Repositories.IRepository;

namespace StudentPortal.BusinessServiceLayer
{
    public class StudentService: IStudentService
    {
        private readonly IMapper _mapper;
       private IEFRepository<Student> _iEFRepository;
        private IEFRepositoryReadOnly<Student> _iEFRepositoryReadOnly;
        private IStudentRepository _StudentRepository;

        public StudentService(IMapper mapper, IEFRepository<Student> iEFRepository, IEFRepositoryReadOnly<Student> eFRepositoryReadOnly, IStudentRepository _studentRepository)
        {
            _mapper = mapper;
           this._iEFRepository = iEFRepository;
            this._iEFRepositoryReadOnly = eFRepositoryReadOnly;
              this._StudentRepository = _studentRepository;

        }
            public IEnumerable<StudentViewModel> Get()
        {
            var st = _iEFRepositoryReadOnly.Get();
            var Viewmodel = _mapper.Map<IEnumerable<StudentViewModel>>(st);
            return Viewmodel;
        }  
        public bool Update(StudentViewModel student)
        {
            var model = _mapper.Map<Student>(student);
            return _iEFRepository.Update(model);
            //var model = _mapper.Map<Student>(student);
            //bool Success = _StudentRepository.Update(model);
            //return Success;
        }

        public bool Insert(StudentViewModel student)
        {
            var model = _mapper.Map<Student>(student);
            return _iEFRepository.Create(model);
           
        }

        public StudentViewModel GetById(int id)
        {
            var st = _iEFRepositoryReadOnly.GetById(id);
           var Viewmodel = _mapper.Map<StudentViewModel>(st);
            return Viewmodel;
        }

        public void Delete(int id)
        {
             _iEFRepository.Delete(id);
            
            //_StudentRepository.Delete(id);
        }
       public IEnumerable<StudentViewModel> GetStudentAddress()
        {
            var st = _StudentRepository.GetStudentAddress();
            var Viewmodel = _mapper.Map<IEnumerable<StudentViewModel>>(st);
            return Viewmodel;
        }
    }
}
