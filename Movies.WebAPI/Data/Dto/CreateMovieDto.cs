using System.ComponentModel.DataAnnotations;

namespace Movies.WebAPI.Data.Dto
{
    public class CreateMovieDto
    {
        [Required(ErrorMessage = "Please enter the title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the Director")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Please enter the Genre")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Please enter the Duration")]
        public int Duration { get; set; }
    }
}
