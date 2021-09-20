using System;
using System.ComponentModel.DataAnnotations;

namespace Movies.WebAPI.Data.Dto
{
    public class DeleteMovieDto
    {
        [Key]
        [Required(ErrorMessage = "Please enter the id")]
        public Guid Id { get; set; }
    }
}
