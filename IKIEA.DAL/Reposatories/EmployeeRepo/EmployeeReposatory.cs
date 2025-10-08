using IKIEA.DAL.Contexts;
using IKIEA.DAL.Models.Departments;
using IKIEA.DAL.Models.Employee;
using IKIEA.DAL.Reposatories.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKIEA.DAL.Reposatories.EmployeeRepo
{
    public class EmployeeReposatory:GenericReposatory<Employee>, IEmployeeReposatory
    {
        private readonly ApplicationDbContext _context;
        public EmployeeReposatory(ApplicationDbContext context):base(context) 
        {
            _context = context;
        }

        //public IEnumerable<Employee> GetAll(bool withtracking = false)
        //{
        //    if (withtracking)
        //    {
        //        return _context.Employees.ToList();
        //    }
        //    else { return _context.Employees.AsNoTracking().ToList(); }

        //}

        //public Employee GetByID(int id)
        //{
        //    var result = _context.Employees.Find(id);
        //    return result;
        //}


        //public int Add(Employee Employee)
        //{
        //    _context.Employees.Add(Employee);
        //    return _context.SaveChanges();
        //}


        //public int Update(Employee Employee)
        //{
        //    _context.Employees.Update(Employee);
        //    return _context.SaveChanges();
        //}


        //public int Delete(int id)
        //{
            
        //        var resultDEL = _context.Employees.Find(id);
        //        _context.Employees.Remove(resultDEL);

        //        return _context.SaveChanges();
           
        //}



    }
}
