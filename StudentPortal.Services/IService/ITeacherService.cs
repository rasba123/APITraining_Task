using StudentPortal.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Services.IService
{
    public interface ITeacherService
    {
        IEnumerable<TeacherViewModel> Get();
        TeacherViewModel GetById(int id);
        bool Update(TeacherViewModel studentViewModel);
        bool Insert(TeacherViewModel student);
        void Delete(int id);
    }
}
