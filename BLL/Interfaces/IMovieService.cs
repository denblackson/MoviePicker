using Domain.Entities;

namespace BLL.Interfaces
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetMoviesAsync();
        Task<Movie> GetMovieByIdAsync(int id);
        Task<IEnumerable<Movie>> SearchMoviesByTitleAsync(string title);
        Task<IEnumerable<Movie>> SearchMoviesByDirectorAsync(string director);
        Task<IEnumerable<Movie>> SearchMoviesByGenreAsync(string genre);
        Task<IEnumerable<Movie>> SearchMoviesByYearAsync(int year);
        Task AddMovieAsync(Movie movie);
        Task UpdateMovieAsync(Movie movie);
        Task DeleteMovieAsync(int id);
    }
}
