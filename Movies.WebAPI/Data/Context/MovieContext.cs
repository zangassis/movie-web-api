using Microsoft.EntityFrameworkCore;
using Movies.WebAPI.Models.v1;

namespace Movies.WebAPI.Data.Context
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options): base(options) { }

        public DbSet<Movie> Movies { get; set; }
    }
}
