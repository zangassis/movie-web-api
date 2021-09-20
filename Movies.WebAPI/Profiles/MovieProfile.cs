using AutoMapper;
using Movies.WebAPI.Data.Dto;
using Movies.WebAPI.Models.v1;

namespace Movies.WebAPI.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<CreateMovieDto, Movie>();
            CreateMap<UpdateMovieDto, Movie>();
            CreateMap<Movie, ReadMovieDto>();
        }
    }
}
