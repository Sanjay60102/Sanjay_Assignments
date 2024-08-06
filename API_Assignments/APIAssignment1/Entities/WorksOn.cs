using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIAssignment1.Entities
{
    public class WorksOn
    {
        [Key]
        public int WorksOnId { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        [StringLength(30)]
        public string Job {  get; set; }
        [Column(TypeName="Date")]
        public DateTime EnterDate { get; set; }

        //Navigation
        public Employee Employee { get; set; }
        public Project Project { get; set; }
    }
}
