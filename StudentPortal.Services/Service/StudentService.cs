
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

namespace StudentPortal.BusinessServiceLayer
{
    public class StudentService: IStudentService
    {
        private readonly IMapper _mapper;
       private IEFRepository _iEFRepository;
        private IEFRepositoryReadOnly _iEFRepositoryReadOnly;
        
        public StudentService(IMapper mapper, IEFRepository iEFRepository, IEFRepositoryReadOnly eFRepositoryReadOnly)
        {
            _mapper = mapper;
           this._iEFRepository = iEFRepository;
            this._iEFRepositoryReadOnly = eFRepositoryReadOnly;
        }
            public IEnumerable<StudentViewModel> Get()
        {
            var st = _iEFRepositoryReadOnly.Get<Student>();
            var Viewmodel = _mapper.Map<IEnumerable<StudentViewModel>>(st);
            return Viewmodel;
        }  
        public bool Update(StudentViewModel student)
        {
            var model = _mapper.Map<Student>(student);
            return _iEFRepository.Update<Student>(model);
            //var model = _mapper.Map<Student>(student);
            //bool Success = _StudentRepository.Update(model);
            //return Success;
        }

        public bool Insert(StudentViewModel student)
        {
            var model = _mapper.Map<Student>(student);
            return _iEFRepository.Create<Student>(model);
           
        }

        public StudentViewModel GetById(int id)
        {
            var st = _iEFRepositoryReadOnly.GetById<Student>(id);
           var Viewmodel = _mapper.Map<StudentViewModel>(st);
            return Viewmodel;
        }

        public void Delete(int id)
        {
             _iEFRepository.Delete<Student>(id);
            
            //_StudentRepository.Delete(id);
        }

       
    }
}
