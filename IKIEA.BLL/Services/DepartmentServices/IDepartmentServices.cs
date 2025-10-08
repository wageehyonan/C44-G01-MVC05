using IKIEA.BLL.Dto_s.DepartmentDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKIEA.BLL.Services.DepartmentServices
{
    public interface IDepartmentServices
    {
        public IEnumerable<DepartmentDto> GetAllDepartment();

        public DepartmentDetailsDto GetDepartmentById(int id);


        public int AddDepartment(AddDepartmentDto dto);


        public int UpdateDepartment(UpdateDepartmentDto dto);


        public int DeleteDepartment(int id);
    }
}
