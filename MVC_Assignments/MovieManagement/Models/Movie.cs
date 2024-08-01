using System.ComponentModel.DataAnnotations;

namespace MovieManagement.Models
{
    public class Movie
    {
        [Required(ErrorMessage ="Please Enter MovieId")]
        public int MovieId { get; set; }
        [Required(ErrorMessage = "Please Enter Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Enter Actor")]
        public string Actor { get; set; }
        [Required(ErrorMessage = "Please Enter language")]
        public string language { get; set; }
        public string Director { get; set; }
    }
}
