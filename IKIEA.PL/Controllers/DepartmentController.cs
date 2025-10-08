using IKIEA.BLL.Dto_s.DepartmentDto_s;
using IKIEA.BLL.Services.DepartmentServices;
using IKIEA.PL.ViewModels.DepartmentVms;
using Microsoft.AspNetCore.Mvc;

namespace IKIEA.PL.Controllers
{
    public class DepartmentController : Controller
    {

        #region Services Injection && Handel Error

        private readonly IDepartmentServices departmentService;
        private readonly ILogger<DepartmentController> logger;
        private readonly IWebHostEnvironment webhost;

        public DepartmentController(IDepartmentServices department, ILogger<DepartmentController> logger, IWebHostEnvironment webhost)

        {
            this.departmentService = department;
            this.logger = logger;
            this.webhost = webhost;
        }
        #endregion


        #region Show All Departments
        public IActionResult Index()
        {
            var DepList = departmentService.GetAllDepartment();
            return View(DepList);
        }
        #endregion
        #region Show Department's Details
        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return BadRequest();
            }


            else
            {
                var DepShowById = departmentService.GetDepartmentById(Id.Value);

                if (DepShowById == null)
                {
                    return NotFound();

                }
                else
                {
                    return View(DepShowById);
                }
            }

        }
        #endregion

        #region Department's  Creation 
        [HttpGet]
        public IActionResult Creation() => View();

        public IActionResult Creation(AddDepartmentDto Dto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int result = departmentService.AddDepartment(Dto);
                    if (result > 0)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Department Cant Be Created");
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

        #region Department's Update
        [HttpGet]
        public IActionResult Update(int? id)
        {

            if (id == null)
            {
                return BadRequest();
            }


            var department = departmentService.GetDepartmentById(id.Value);
            if (department == null) return NotFound();

            var ViewDepModel = new DepartmentViewModel()
            {
                Id = department.Id,
                code = department.code,
                Name = department.Name,
                Description = department.Description,
            };
            return View(ViewDepModel);
        }

        [HttpPost]
        public IActionResult Update([FromRoute] int id, DepartmentViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            var ViewDepModel = new UpdateDepartmentDto()
            {
                Id = id,
                code = model.code,
                Name = model.Name,
                Description = model.Description,
            };

            try
            {
                int result = departmentService.UpdateDepartment(ViewDepModel);
                if (result > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Department Cant Be Updated");
                    return View(model);
                }
            }
            catch (Exception ex)
            {
                if (webhost.IsDevelopment())
                {
                    logger.LogError(ex.Message);
                    return View(model);

                }
                else
                {
                    throw;
                }
            }

        }

        #endregion
        #region Department's Delete


        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id is null)
            {
                BadRequest();

            }
            var department = departmentService.GetDepartmentById(id.Value);
            if (department == null)
            {
                return NotFound();

            }
            return View(department);
        }
        [HttpPost]
        public IActionResult Delete(int id)

        {
            try
            {

                int result = departmentService.DeleteDepartment(id);
                if (result > 0)
                    return RedirectToAction("Index");

                ModelState.AddModelError(string.Empty, "Department Cant Be Deleted");
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
