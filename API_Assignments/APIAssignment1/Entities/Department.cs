using System.ComponentModel.DataAnnotations;

namespace APIAssignment1.Entities
{
    public class Department
    {
        [Key]
        public string DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        public string Location { get; set; }
    }
}
