using BLL.Interfaces;
using DAL.Interfaces;
using Domain.Entities;

namespace BLL.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<IEnumerable<Movie>> GetMoviesAsync()
        {
            return await _movieRepository.GetMoviesAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await _movieRepository.GetMovieByIdAsync(id);
        }

        public async Task AddMovieAsync(Movie movie)
        {
            await _movieRepository.AddMovieAsync(movie);
        }

        public async Task UpdateMovieAsync(Movie movie)
        {
            await _movieRepository.UpdateMovieAsync(movie);
        }

        public async Task DeleteMovieAsync(int id)
        {
            await _movieRepository.DeleteMovieAsync(id);
        }

        public async Task<IEnumerable<Movie>> SearchMoviesByTitleAsync(string title)
        {
           return await _movieRepository.SearchMoviesByTitle(title);
        }

        public async Task<IEnumerable<Movie>> SearchMoviesByDirectorAsync(string director)
        {
            return await _movieRepository.SearchMoviesByDirector(director);
        }

        public async Task<IEnumerable<Movie>> SearchMoviesByGenreAsync(string genre)
        {
            return await _movieRepository.SearchMoviesByGenre(genre);
        }

        public async Task<IEnumerable<Movie>> SearchMoviesByYearAsync(int year)
        {
            return await _movieRepository.SearchMoviesByYear(year);
        }
    }
}

