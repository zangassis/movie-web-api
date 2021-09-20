using Movies.WebAPI.Data.Dto;
using System;
using System.Collections.Generic;

namespace Movies.WebAPI.Services
{
    public interface IMovieService
    {
        IEnumerable<ReadMovieDto> Get();
        ReadMovieDto GetById(Guid id);
        void Create(CreateMovieDto movieDto);
        UpdateMovieDto Update(Guid id, UpdateMovieDto movieDto);
        bool Delete(Guid id);
    }
}
