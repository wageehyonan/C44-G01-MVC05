using IKIEA.BLL.Dto_s.DepartmentDto_s;
using IKIEA.BLL.Factories.DepartmentFactory;
using IKIEA.DAL.Reposatories.DepartmentRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IKIEA.BLL.Services.DepartmentServices.DepartmentServices;

namespace IKIEA.BLL.Services.DepartmentServices
{
    public class DepartmentServices: IDepartmentServices
    {
        private readonly IDepartmentReposatory _reposatory;

        public DepartmentServices(IDepartmentReposatory reposatory)

            {
               
            this._reposatory = reposatory;
        }
            public IEnumerable<DepartmentDto> GetAllDepartment()
            {

                var departments = _reposatory.GetAll();
                //manual mappingg
                //var departmentMaped = departments.Select(D => new DepartmentDto
                //           {
                //                Id = D.Id,
                //               Name = D.Name,
                //               Code = D.Code,
                //                Description = D.Description,
                //            }
                //               );
                List<DepartmentDto> department_maped_List = new List<DepartmentDto>();
                foreach (var dept in departments)
                {
                    var department_maped = dept.ToDepartmentDto();
                    department_maped_List.Add(department_maped);

                }

                return department_maped_List;
            }

            public DepartmentDetailsDto GetDepartmentById(int id)

            {
                var Department = _reposatory.GetByID(id);

                if (Department is null)
                { return null; }
                else
                {
                    //************** THIS WAY NAMED MANUAL MAPPING
                    //var DepartmentToReturn = new DepartmentDetailsDto
                    // {
                    //     Id=departments.Id,
                    //     Name = departments.Name,
                    //     code = departments.Code,
                    //     Description = departments.Description,
                    //     CreatedBy = departments.CreatedBy,
                    //    CreatedOn = DateOnly.FromDateTime(departments.CreatedOn),
                    //     LastModifiedBy=departments.LastModifiedBy,
                    //     LastModifiedOn=DateOnly.FromDateTime(departments.LastModifiedOn),
                    // };

                    // var DepartmentToReturn=new DepartmentDetailsDto(Department);
                    return Department.ToDepartmentDetailsDto();
                    //var DepartmentToReturn= Department.ToDepartmentDetailsDto();
                    //return DepartmentToReturn;
                }

            }

            public int AddDepartment(AddDepartmentDto dto)
            {
                var dtoAdd = dto.ToAddDepartmentDto();
                return _reposatory.Add(dtoAdd);

            }

            public int UpdateDepartment(UpdateDepartmentDto dto)
            {
                var UpDep = dto.ToUpdateDepartmentDto();
                return _reposatory.Update(UpDep);

            }

            public int DeleteDepartment(int id)
            {
                return _reposatory.Delete(id);
            }

        }
    }
