using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace APIAssignment1.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeName { get; set; }
        [ForeignKey("Department")]
        public string DepartmentId { get; set; }

        //Navogation 
        public Department Department { get; set; }
    }
}
