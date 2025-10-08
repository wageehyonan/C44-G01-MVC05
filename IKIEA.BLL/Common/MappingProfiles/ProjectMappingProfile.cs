using AutoMapper;
using AutoMapper.Configuration.Conventions;
using IKIEA.BLL.Dto_s.EmployeeDto_s;
using IKIEA.DAL.Models.Employee;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKIEA.BLL.Common.MappingProfiles
{
    public class ProjectMappingProfile:Profile
    {
        public ProjectMappingProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Employee,EmployeeDetailsDto>().ReverseMap();
            CreateMap<AddEmployeeDto, Employee>().ReverseMap();
            CreateMap<UpdateEmployeeDto,Employee>().ReverseMap();
            
            //IF Two Fields are diffrent in Coulmn name
            //CreateMap<UpdateEmployeeDto, Employee>().ReverseMap().ForMember(dest=>dest.Address,option=>option.MapFrom(src=>src.Address));

        }
    }
}
