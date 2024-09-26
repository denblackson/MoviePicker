using BLL.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MoviePickerAPI.Controllers
{
    [ApiController]
    [Route("api/movies/{movieId}/[controller]")]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpGet]
        public async Task<IActionResult> GetReviews(int movieId)
        {
            var reviews = await _reviewService.GetReviewsByMovieIdAsync(movieId);
            return Ok(reviews);
        }

        [HttpPost]
        public async Task<IActionResult> AddReview(int movieId, [FromBody] Review review)
        {
            review.MovieId = movieId;
            await _reviewService.AddReviewAsync(review);
            return Ok();
        }
    }
}
