using System.ComponentModel.DataAnnotations;

namespace APIAssignment1.Entities
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        [Required]
        [StringLength(50)]
        public string ProjectName { get; set; }
        [Required]
        public int Budget {  get; set; }
    }
}
