using Domain.Entities;

namespace DAL.Interfaces
{
    public interface IReviewRepository
    {
        Task<IEnumerable<Review>> GetReviewsByMovieIdAsync(int movieId);
        Task<IEnumerable<Review>> GetReviewsByMovieTitleAsync(int movieId);
        Task AddReviewAsync(Review review);
    }
}
