using AutoMapper;
using StudentPortal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<StudentDTO, StudentViewModel>().ReverseMap();
                
        }
    }
}
