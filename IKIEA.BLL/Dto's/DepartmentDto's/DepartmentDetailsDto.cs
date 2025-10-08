using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKIEA.BLL.Dto_s.DepartmentDto_s
{
    public class DepartmentDetailsDto
    {
        // MAPPING BY COUNSTRUCTOR

        //public DepartmentDetailsDto(Department department)
        //{
        //    Id = department.Id;
        //    Name = department.Name;
        //    code = department.Code;
        //    Description = department.Description;
        //    CreatedBy = department.CreatedBy;
        //    CreatedOn = DateOnly.FromDateTime(department.CreatedOn);
        //    LastModifiedBy = department.LastModifiedBy;
        //    LastModifiedOn = DateOnly.FromDateTime(department.LastModifiedOn);
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public string code { get; set; }
        public string? Description { get; set; }

        public int CreatedBy { get; set; }//user id
        public DateOnly CreatedOn { get; set; }
        public int LastModifiedBy { get; set; }    //user id
        public DateOnly LastModifiedOn { get; set; }

    }
}
