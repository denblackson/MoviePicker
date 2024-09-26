using BLL.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MoviePickerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            var movies = await _movieService.GetMoviesAsync();
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovieById(int id)
        {
            var movie = await _movieService.GetMovieByIdAsync(id);
            if (movie == null) return NotFound();
            return Ok(movie);
        }

        [HttpGet("title")]
        //[HttpGet]
        public async Task<IActionResult> GetMovieByTitle([FromQuery] string title)
        {
            var movie = await _movieService.SearchMoviesByTitleAsync(title);
            if (movie == null) return NotFound();
            return Ok(movie);
        }

        [HttpGet("director")]
        public async Task<IActionResult> GetMovieByDirector([FromQuery] string director)
        {
            var movie = await _movieService.SearchMoviesByDirectorAsync(director);
            if (movie == null) return NotFound();
            return Ok(movie);
        }

        [HttpGet("genre")]
        public async Task<IActionResult> GetMovieByGenre([FromQuery] string genre)
        {
            var movie = await _movieService.SearchMoviesByGenreAsync(genre);
            if (movie == null) return NotFound();
            return Ok(movie);
        }

        [HttpGet("year")]
        public async Task<IActionResult> GetMovieByYear([FromQuery] int year)
        {
            var movie = await _movieService.SearchMoviesByYearAsync(year);
            if (movie == null) return NotFound();
            return Ok(movie);
        }

        [HttpPost]
        public async Task<IActionResult> AddMovie([FromBody] Movie movie)
        {
            await _movieService.AddMovieAsync(movie);
            return Ok();
        }

        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateMovie(int id, [FromBody] Movie movie)
        //{
        //    if (id != movie.Id) return BadRequest();
        //    await _movieService.UpdateMovieAsync(movie);
        //    return Ok();
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteMovie(int id)
        //{
        //    await _movieService.DeleteMovieAsync(id);
        //    return Ok();
        //}
    }
}
