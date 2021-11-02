using StudentPortal.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Services.IService
{
    public interface IEnrollmentService
    {
        IEnumerable<EnrollmentViewModel> Get();
        EnrollmentViewModel GetById(int id);
        bool Update(EnrollmentViewModel studentViewModel);
        bool Insert(EnrollmentViewModel student);
        void Delete(int id);
    }
}
