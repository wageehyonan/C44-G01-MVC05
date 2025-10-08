using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKIEA.DAL.Models.Shared
{
    public class BaseEntity
    {

        public int Id { get; set; }//id
        public int CreatedBy { get; set; }//user id
        public DateTime CreatedOn { get; set; }
        public int LastModifiedBy { get; set; }    //user id
        public DateTime LastModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
