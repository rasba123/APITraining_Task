using StudentPortal.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Services.IService
{
   public interface ICourseService
    {
        IEnumerable<CourseViewModel> Get();
        CourseViewModel GetById(int id);
        bool Update(CourseViewModel studentViewModel);
        bool Insert(CourseViewModel student);
        void Delete(int id);
    }
}
