using System;
using System.ComponentModel.DataAnnotations;

namespace Movies.WebAPI.Models.v1
{
    public class Movie
    {
        [Key]
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();

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
