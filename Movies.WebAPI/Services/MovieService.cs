using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Movies.WebAPI.Data.Context;
using Movies.WebAPI.Data.Dto;
using Movies.WebAPI.Models.v1;
using System;
using System.Collections.Generic;

namespace Movies.WebAPI.Services
{
    public class MovieService : IMovieService
    {
        private readonly MovieContext _context;
        private readonly IMapper _mapper;

        public MovieService(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<ReadMovieDto> Get()
        {
            var movies = _context.Movies;
            return _mapper.Map<List<ReadMovieDto>>(movies);
        }

        public void Create(CreateMovieDto movieDto)
        {
            var movie = _mapper.Map<Movie>(movieDto);

            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public ReadMovieDto GetById(Guid id)
        {
            var movie = _context.Movies.FirstOrDefaultAsync(movie => movie.Id == id);

            if (movie.Result is not null)
            {
                var movieDto = _mapper.Map<ReadMovieDto>(movie.Result);
                return movieDto;
            }
            else
                return null;
        }

        public UpdateMovieDto Update(Guid id, UpdateMovieDto movieDto)
        {
            var movie = _context.Movies.FirstOrDefaultAsync(movie => movie.Id == id);

            if (movie.Result is null)
                return null;

            _mapper.Map(movieDto, movie.Result);
            _context.SaveChanges();

            return movieDto;
        }

        public bool Delete(Guid id)
        {
            var validId = true;

            var getMovie = _context.Movies.FirstOrDefaultAsync(movie => movie.Id == id);

            if (getMovie.Result is null)
                return validId == false;

            _context.Remove(getMovie.Result);
            _context.SaveChanges();
            return validId;
        }
    }
}
