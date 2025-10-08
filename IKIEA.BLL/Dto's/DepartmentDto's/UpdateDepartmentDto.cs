using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKIEA.BLL.Dto_s.DepartmentDto_s
{
    public class UpdateDepartmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string code { get; set; }
        public string? Description { get; set; }

        public int CreatedBy { get; set; }//user id
        public DateTime CreatedOn { get; set; }
        public int LastModifiedBy { get; set; }    //user id
        public DateTime LastModifiedOn { get; set; }
    }
}
