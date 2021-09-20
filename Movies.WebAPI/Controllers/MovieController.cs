using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Movies.WebAPI.Data.Dto;
using Movies.WebAPI.Services;
using System;

namespace Movies.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _service;
        public MovieController(IMovieService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var movies = _service.Get();
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var movie = _service.GetById(id);

            if (movie is not null)
                return Ok(movie);
            else
                return NotFound($"Not Found book for id: {id}");
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateMovieDto movieDto)
        {
            _service.Create(movieDto);
            return Ok(movieDto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] UpdateMovieDto movieDto)
        {
            var newVersion = _service.Update(id, movieDto);

            if (newVersion is not null)
                return Ok(newVersion);

            else
                return NotFound($"Not Found book for id: {id}");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var validId = _service.Delete(id);

            if (validId)
                return NoContent();

            else
                return NotFound($"Not Found book for id: {id}");
        }
    }
}
