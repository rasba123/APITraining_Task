using AutoMapper;
using StudentPortal.Model.GenericRepository.IRepository;
using StudentPortal.Model.Models;
using StudentPortal.Services.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Services.Service
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IMapper _mapper;
        private IEFRepository<Enrollment> _iEFRepository;
        private IEFRepositoryReadOnly<Enrollment> _iEFRepositoryReadOnly;

        public EnrollmentService(IMapper mapper, IEFRepository<Enrollment> iEFRepository, IEFRepositoryReadOnly<Enrollment> eFRepositoryReadOnly)
        {
            _mapper = mapper;
            this._iEFRepository = iEFRepository;
            this._iEFRepositoryReadOnly = eFRepositoryReadOnly;
        }
        public IEnumerable<EnrollmentViewModel> Get()
        {
            var st = _iEFRepositoryReadOnly.Get<Enrollment>();
            var Viewmodel = _mapper.Map<IEnumerable<EnrollmentViewModel>>(st);
            return Viewmodel;
        }
        public bool Update(EnrollmentViewModel student)
        {
            var model = _mapper.Map<Enrollment>(student);
            return _iEFRepository.Update<Enrollment>(model);
            //var model = _mapper.Map<Student>(student);
            //bool Success = _StudentRepository.Update(model);
            //return Success;
        }

        public bool Insert(EnrollmentViewModel student)
        {
            var model = _mapper.Map<Enrollment>(student);
            return _iEFRepository.Create<Enrollment>(model);

        }

        public EnrollmentViewModel GetById(int id)
        {
            var st = _iEFRepositoryReadOnly.GetById<Enrollment>(id);
            var Viewmodel = _mapper.Map<EnrollmentViewModel>(st);
            return Viewmodel;
        }

        public void Delete(int id)
        {
            _iEFRepository.Delete<Student>(id);

            //_StudentRepository.Delete(id);
        }
       
    }
}
