using IKIEA.DAL.Models.Employee;
using IKIEA.DAL.Reposatories.GenericRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKIEA.DAL.Reposatories.EmployeeRepo
{
    public interface IEmployeeReposatory:IGenericReposatory<Employee>
    {
        public IEnumerable<Employee> GetAll(bool withtracking = false);

        public Employee GetByID(int id);


        public int Add(Employee Employee);



        public int Update(Employee Employee);



        public int Delete(int id);
        
    }
}
