using IKIEA.DAL.Models.Departments;
using IKIEA.DAL.Reposatories.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKIEA.DAL.Reposatories.DepartmentRepo
{
    public interface IDepartmentReposatory:IGenericReposatory<Department>
    {
        public IEnumerable<Department> GetAll(bool withtracking = false);
        public Department GetByID(int id);
        public int Add(Department department);
        public int Update(Department department);
        public int Delete(int id);

    }
}
