using IKIEA.BLL.Dto_s.DepartmentDto_s;
using IKIEA.DAL.Models.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKIEA.BLL.Factories.DepartmentFactory
{
    public static class DepartmentFact
    {

        public static DepartmentDto ToDepartmentDto(this Department D) //factory must be static
        {
            ///EXCETION METHOD
            return new DepartmentDto()
            {
                Id = D.Id,
                Name = D.Name,
                Code = D.Code,
                Description = D.Description,
            };
        }

        public static DepartmentDetailsDto ToDepartmentDetailsDto(this Department D)

        {
            return new DepartmentDetailsDto()
            {
                Id = D.Id,
                Name = D.Name,
                code = D.Code,
                Description = D.Description,
                CreatedBy = D.CreatedBy,
                CreatedOn = DateOnly.FromDateTime(D.CreatedOn),
                LastModifiedBy = D.LastModifiedBy,
                LastModifiedOn = DateOnly.FromDateTime(D.LastModifiedOn),
            };


        }

        public static Department ToAddDepartmentDto(this AddDepartmentDto dto)
        {
            return new Department()
            {
                Name = dto.Name,
                Code = dto.code,
                Description = dto.Description,
                CreatedBy = 1,
                CreatedOn = DateTime.Now,
                LastModifiedBy = 1,
                LastModifiedOn = DateTime.Now,
                IsDeleted = false,
            };
        }

        public static Department ToUpdateDepartmentDto(this UpdateDepartmentDto D)
        {
            return new Department()
            {
                Id = D.Id,
                Name = D.Name,
                Code = D.code,
                Description = D.Description,
                LastModifiedBy = D.LastModifiedBy,
                LastModifiedOn = DateTime.Now,
                IsDeleted = false,
            };

        }
    }
}
