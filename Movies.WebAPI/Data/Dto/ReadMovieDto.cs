using System;

namespace Movies.WebAPI.Data.Dto
{
    public class ReadMovieDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
    }
}
