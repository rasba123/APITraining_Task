using AutoMapper;
using StudentPortal.Model;
using StudentPortal.Model.Models;
using StudentPortal.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;


namespace StudentPortal
{
    public class AutoMapperProfile : Profile
    {
      
        public AutoMapperProfile()
        {
        
            CreateMap<StudentViewModel, Student>().ConvertUsing(new ViewModelToDTOConverter());
            CreateMap<Student, StudentViewModel>().ConvertUsing(new DTOToViewModelConverter());
            CreateMap<TeacherViewModel, Teacher>().ReverseMap();
            CreateMap<EnrollmentViewModel, Enrollment>().ReverseMap();
            CreateMap<TeacherEnrollementViewModel, TeacherEnrollment>().ReverseMap();
            
        }
    }
    
    public class ViewModelToDTOConverter : ITypeConverter<StudentViewModel, Student>
    {
        public Student Convert(StudentViewModel source, Student destination, ResolutionContext context)
        {
         
          destination = new Student()
            {
                // Percentage = source.Percentage.ToString(),
                StudentId = source.StudentId,
                StudentName = source.StudentName,
                StudentPhone = source.StudentPhone,
                 Marks1 = source.Marks1,
                Marks2 = source.Marks2,
                Marks3 = source.Marks3,

            };
            return destination;
        }
    }
    public class DTOToViewModelConverter : ITypeConverter<Student, StudentViewModel>
    {
        public StudentViewModel Convert(Student source, StudentViewModel destination, ResolutionContext context)
        {
            destination = new StudentViewModel()
            {
                //Percentage = System.Convert.ToInt32(source.Percentage),
                StudentId = source.StudentId,
                StudentName = source.StudentName,
                StudentPhone = source.StudentPhone,
                Marks1 =source.Marks1,
                Marks2 = source.Marks2,
                Marks3 = source.Marks3,

            };
            return destination;
        }
    }
}
