using System.ComponentModel.DataAnnotations;

namespace IKIEA.PL.ViewModels.DepartmentVms
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name Is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Code Is Required")]
        public string code { get; set; }
        public string? Description { get; set; }
    }
}
