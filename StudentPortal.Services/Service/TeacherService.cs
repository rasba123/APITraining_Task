
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
using StudentPortal.Services.ViewModels;
using StudentPortal.Services.IService;

namespace StudentPortal.Services.Service
{
  public class TeacherService : ITeacherService
    {

        private readonly IMapper _mapper;
        private IEFRepository _iEFRepository;
        private IEFRepositoryReadOnly _iEFRepositoryReadOnly;

        public TeacherService(IMapper mapper, IEFRepository iEFRepository, IEFRepositoryReadOnly eFRepositoryReadOnly)
        {
            _mapper = mapper;
            this._iEFRepository = iEFRepository;
            this._iEFRepositoryReadOnly = eFRepositoryReadOnly;
        }
        public IEnumerable<TeacherViewModel> Get()
        {
            var st = _iEFRepositoryReadOnly.Get<Teacher>();
            var Viewmodel = _mapper.Map<IEnumerable<TeacherViewModel>>(st);
            return Viewmodel;
        }
        public bool Update(TeacherViewModel teacher)
        {
            var model = _mapper.Map<Teacher>(teacher);
            return _iEFRepository.Update<Teacher>(model);
            //var model = _mapper.Map<Student>(student);
            //bool Success = _StudentRepository.Update(model);
            //return Success;
        }

        public bool Insert(TeacherViewModel teacher)
        {
            var model = _mapper.Map<Teacher>(teacher);
            return _iEFRepository.Create<Teacher>(model);

        }

        public TeacherViewModel GetById(int id)
        {
            var st = _iEFRepositoryReadOnly.GetById<Teacher>(id);
            var Viewmodel = _mapper.Map<TeacherViewModel>(st);
            return Viewmodel;
        }

        public void Delete(int id)
        {
            _iEFRepository.Delete<Teacher>(id);

            //_StudentRepository.Delete(id);
        }


    }
}

