using Domain.Entities;

namespace DAL.Interfaces
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetMoviesAsync();
        Task<Movie> GetMovieByIdAsync(int id);
        Task AddMovieAsync(Movie movie);
        Task UpdateMovieAsync(Movie movie);
        Task DeleteMovieAsync(int id);
        Task<IEnumerable<Movie>> SearchMoviesByTitle(string title);
        Task<IEnumerable<Movie>> SearchMoviesByDirector(string director);
        Task<IEnumerable<Movie>> SearchMoviesByGenre(string genre);
        Task<IEnumerable<Movie>> SearchMoviesByYear(int year);
    }
}
