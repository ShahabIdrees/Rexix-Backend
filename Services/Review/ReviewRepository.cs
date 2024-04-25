using Microsoft.EntityFrameworkCore;
using RexixBackend.Data;
using RexixBackend.DTOs;

namespace RexixBackend.Services.Review
{
    public class ReviewRepository : IReviewRepository
    {
        public readonly AppDbContext _context;

        public ReviewRepository(AppDbContext context)
        {
            _context = context;
        }
        // Add your class members here
        public async Task<List<ReviewDTO>> AddReview(ReviewDTO Review)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ReviewDTO>> DeleteReview(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ReviewDTO>> GetAllReviews()
        {
            var reviews = await _context.Review.ToListAsync();
            return reviews;
        }

        public async Task<ReviewDTO> GetReview(Guid id)
        {
            throw new NotImplementedException();
        }

        async public Task<List<ReviewDTO>> UpdateReview(Guid id, ReviewDTO Review)
        {
            throw new NotImplementedException();
        }
    }
}