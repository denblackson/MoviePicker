using Domain.Entities;

namespace BLL.Interfaces
{
    public interface IReviewService
    {
        Task<IEnumerable<Review>> GetReviewsByMovieIdAsync(int movieId);
        Task AddReviewAsync(Review review);
    }
}
