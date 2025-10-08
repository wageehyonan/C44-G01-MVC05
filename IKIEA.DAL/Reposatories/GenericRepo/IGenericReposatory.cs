using IKIEA.DAL.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKIEA.DAL.Reposatories.GenericRepo
{
    public interface IGenericReposatory<TEntity> where TEntity : BaseEntity
    {
        public IEnumerable<TEntity> GetAll(bool withtracking = false);

        public TEntity GetByID(int id);


        public int Add(TEntity entity);



        public int Update(TEntity entity);



        public int Delete(int id);

    }
}
