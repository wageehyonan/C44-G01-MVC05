using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKIEA.BLL.Dto_s.DepartmentDto_s
{
    public class AddDepartmentDto
    {
        //public int Id { get; set; }


        [Required(ErrorMessage = "Name Is Required")]
        public string Name { get; set; }



        [Required(ErrorMessage = "Code Is Required")]
        public string code { get; set; }
        public string? Description { get; set; }
        //public int CreatedBy { get; set; }//user id
        //public DateOnly CreatedOn { get; set; }
        //public int LastModifiedBy { get; set; }    //user id
        //public DateOnly LastModifiedOn { get; set; }

    }
}
