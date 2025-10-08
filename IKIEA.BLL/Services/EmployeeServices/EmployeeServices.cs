using AutoMapper;
using IKIEA.BLL.Dto_s.DepartmentDto_s;
using IKIEA.BLL.Dto_s.EmployeeDto_s;
using IKIEA.DAL.Models.Employee;
using IKIEA.DAL.Reposatories.DepartmentRepo;
using IKIEA.DAL.Reposatories.EmployeeRepo;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKIEA.BLL.Services.EmployeeServices
{
    public class EmployeeServices: IEmployeeServices
    {
        private readonly IEmployeeReposatory _reposatory;
        private readonly IMapper mapper;

        public EmployeeServices(IEmployeeReposatory reposatory,IMapper mapper)

        {

            this._reposatory = reposatory;
            this.mapper = mapper;
        }

       

       

        public IEnumerable<EmployeeDto> GetAllEmployee() 
             => mapper.Map <IEnumerable<Employee>,IEnumerable<EmployeeDto>>(_reposatory.GetAll());
       


        public EmployeeDetailsDto GetEmployeeById(int id)
            
            => mapper.Map<Employee,EmployeeDetailsDto>(_reposatory.GetByID(id));



        public int AddEmployee(AddEmployeeDto dto)
        {
            var emp = mapper.Map<AddEmployeeDto, Employee>(dto);
            emp.CreatedBy = 1;
            emp.CreatedOn=DateTime.Now;
            emp.LastModifiedBy = 1;
            emp.LastModifiedOn=DateTime.Now;
            return _reposatory.Add(emp);

        }

        public int UpdateEmployee(UpdateEmployeeDto dto)
        {
            var emp=mapper.Map<UpdateEmployeeDto,Employee>(dto);
            emp.LastModifiedBy = 1;
            emp.LastModifiedOn=DateTime.Now;
            return _reposatory.Update(emp);

        }


        public int DeleteEmployee(int id)
        {
          if (id!=null)
            {
               return  _reposatory.Delete(id);
            }
          else
                { return 0; }
        }
    }
}
