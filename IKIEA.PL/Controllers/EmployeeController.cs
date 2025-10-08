using IKIEA.BLL.Dto_s.DepartmentDto_s;
using IKIEA.BLL.Dto_s.EmployeeDto_s;
using IKIEA.BLL.Services.DepartmentServices;
using IKIEA.BLL.Services.EmployeeServices;
using IKIEA.DAL.Models.Shared;
using IKIEA.PL.ViewModels.DepartmentVms;
using IKIEA.PL.ViewModels.EmployeeVms;
using Microsoft.AspNetCore.Mvc;

namespace IKIEA.PL.Controllers
{
    public class EmployeeController : Controller
    {
       
        #region Services Injection && Handel Error For Employee Entity

        private readonly IEmployeeServices EmployeeService;
        private readonly ILogger<EmployeeController> logger;
        private readonly IWebHostEnvironment webhost;

        public EmployeeController(IEmployeeServices employee, ILogger<EmployeeController> logger, IWebHostEnvironment webhost)

        {
            this.EmployeeService = employee;
            this.logger = logger;
            this.webhost = webhost;
        }
        #endregion


        #region Show All Employees
        public IActionResult Index()
        {
            var EmpList = EmployeeService.GetAllEmployee();
            return View(EmpList);
        }
        #endregion
        #region Show Employee's Details
        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return BadRequest();
            }


            else
            {
                var EmpShowById = EmployeeService.GetEmployeeById(Id.Value);

                if (EmpShowById == null)
                {
                    return NotFound();

                }
                else
                {
                    return View(EmpShowById);
                }
            }

        }
        #endregion

        #region Employee's  Creation 
        [HttpGet]
        public IActionResult Creation() => View();

        public IActionResult Creation(AddEmployeeDto Dto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int result = EmployeeService.AddEmployee(Dto);
                    if (result > 0)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Employee Cant Be Created");
                        return View(Dto);
                    }
                }
                catch (Exception ex)
                {
                    if (webhost.IsDevelopment())
                    {
                        logger.LogError(ex.Message);
                        return View(Dto);
                    }
                    else
                    {
                        throw;

                    }
                }
            }
            else
            {

                return View(Dto);
            }
        }

        #endregion

        #region Employee's Update
        [HttpGet]
        public IActionResult Update(int? id)
        {

            if (id == null)
            {
                return BadRequest();
            }


            var emp = EmployeeService.GetEmployeeById(id.Value);
            if (emp == null) return NotFound();

            var EmployeeModel = new UpdateEmployeeDto()
            {
              Id= emp.Id,
              Name= emp.Name,
              Address= emp.Address,
              Age= emp.Age,
              Salary= emp.Salary,
              IsActive= emp.IsActive,
              Email= emp.Email,
              HiringDate= emp.HiringDate,
               
               };
            return View(EmployeeModel);
        }

        [HttpPost]
        public IActionResult Update([FromRoute] int id, UpdateEmployeeDto dto)
        {
            if (!ModelState.IsValid) return View(dto);
            

            try
            {
                int result = EmployeeService.UpdateEmployee(dto);
                if (result > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Employee Cant Be Updated");
                    return View(dto);
                }
            }
            catch (Exception ex)
            {
                if (webhost.IsDevelopment())
                {
                    logger.LogError(ex.Message);
                    return View(dto);

                }
                else
                {
                    throw;
                }
            }

        }

        #endregion
        #region Employee's Delete


        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id is null)
            {
                BadRequest();

            }
            var employee = EmployeeService.GetEmployeeById(id.Value);
            if (employee == null)
            {
                return NotFound();

            }
            return View(employee);
        }
        [HttpPost]
        public IActionResult Delete(int id)

        {
            try
            {

                int result = EmployeeService.DeleteEmployee(id);
                if (result > 0)
                    return RedirectToAction("Index");

                ModelState.AddModelError(string.Empty, "Employee Cant Be Deleted");
            }
            catch (Exception ex)
            {
                if (webhost.IsDevelopment())
                {
                    logger.LogError(ex.Message);

                }
                else
                {
                    throw;

                }
            }
            return View("Delete", new { id = id });

        }


        #endregion
    }
}
