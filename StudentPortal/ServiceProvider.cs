using Microsoft.Extensions.DependencyInjection;
using StudentPortal.BusinessServiceLayer;
using StudentPortal.IBusinessServiceLayer;
using StudentPortal.Model.GenericRepository.IRepository;
using StudentPortal.Model.GenericRepository.Repository;
using StudentPortal.Model.Repositories.IRepository;
using StudentPortal.Model.Repositories.Repository;
using StudentPortal.Model.Repository;
using StudentPortal.Services.IService;
using StudentPortal.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal
{
    public class ServiceProvider
    {
        public ServiceProvider(IServiceCollection services)
        {

            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IEnrollmentService, EnrollmentService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped(typeof(IEFRepository<>), typeof(EFRepository<>));
            services.AddScoped(typeof(IEFRepositoryReadOnly<>), typeof(EFRepositoryReadOnly<>));
            services.AddScoped<IStudentRepository, StudentRepository>();
        }

        
    }
}
