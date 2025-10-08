using IKIEA.DAL.Contexts;
using IKIEA.DAL.Models.Departments;
using IKIEA.DAL.Reposatories.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKIEA.DAL.Reposatories.DepartmentRepo
{
    public class DepartmentReposatory: GenericReposatory<Department>, IDepartmentReposatory 
    {
        private readonly ApplicationDbContext _context;
        public DepartmentReposatory(ApplicationDbContext context): base(context) 
        {
            _context = context;
        }

        //public IEnumerable<Department> GetAll(bool withtracking = false)
        //{
        //    if (withtracking)
        //    {
        //        return _context.Departments.ToList();
        //    }
        //    else { return _context.Departments.AsNoTracking().ToList(); }

        //}

        //public Department GetByID(int id)
        //{
        //    var result = _context.Departments.Find(id);
        //    return result;
        //}


        //public int Add(Department department)
        //{
        //    _context.Departments.Add(department);
        //    return _context.SaveChanges();
        //}


        //public int Update(Department department)
        //{
        //    _context.Departments.Update(department);
        //    return _context.SaveChanges();
        //}


        //public int Delete(int id)
        //{
        //    var resultDEL = _context.Departments.Find(id);
        //    _context.Departments.Remove(resultDEL);
        //    return _context.SaveChanges();
        //}



    }
}
