using IKIEA.BLL.Dto_s.DepartmentDto_s;
using IKIEA.BLL.Dto_s.EmployeeDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKIEA.BLL.Services.EmployeeServices
{
    public interface IEmployeeServices
    {
        public IEnumerable<EmployeeDto> GetAllEmployee();

        public EmployeeDetailsDto GetEmployeeById(int id);


        public int AddEmployee(AddEmployeeDto dto);


        public int UpdateEmployee(UpdateEmployeeDto dto);


        public int DeleteEmployee(int id);
    }
}
