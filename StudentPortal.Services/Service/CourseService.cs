using AutoMapper;
using StudentPortal.Model.GenericRepository.IRepository;
using StudentPortal.Model.Models;
using StudentPortal.Services.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Services.Service
{
    public class CourseService : ICourseService
    {
        private readonly IMapper _mapper;
        private IEFRepository<Course> _iEFRepository;
        private IEFRepositoryReadOnly<Course> _iEFRepositoryReadOnly;

        public CourseService(IMapper mapper, IEFRepository<Course> iEFRepository, IEFRepositoryReadOnly<Course> eFRepositoryReadOnly)
        {
            _mapper = mapper;
            this._iEFRepository = iEFRepository;
            this._iEFRepositoryReadOnly = eFRepositoryReadOnly;
        }
        public IEnumerable<CourseViewModel> Get()
        {
            var st = _iEFRepositoryReadOnly.Get<Course>();
            var Viewmodel = _mapper.Map<IEnumerable<CourseViewModel>>(st);
            return Viewmodel;
        }
        public bool Update(CourseViewModel student)
        {
            var model = _mapper.Map<Course>(student);
            return _iEFRepository.Update<Course>(model);
            //var model = _mapper.Map<Student>(student);
            //bool Success = _StudentRepository.Update(model);
            //return Success;
        }

        public bool Insert(CourseViewModel student)
        {
            var model = _mapper.Map<Course>(student);
            return _iEFRepository.Create<Course>(model);

        }

        public CourseViewModel GetById(int id)
        {
            var st = _iEFRepositoryReadOnly.GetById<Course>(id);
            var Viewmodel = _mapper.Map<CourseViewModel>(st);
            return Viewmodel;
        }

        public void Delete(int id)
        {
            _iEFRepository.Delete<Course>(id);

            //_StudentRepository.Delete(id);
        }

    }
}
